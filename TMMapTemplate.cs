using GBX.NET;
using GBX.NET.Engines.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmEssentials;

namespace GbxTest
{
    public class TMMapTemplate
    {
        public TMMapTemplate(CGameCtnChallenge _challenge)
        {
            MapName = _challenge.MapName;
            Start = ParseBlocks(_challenge, BlockMode.START); //vallz: needs a little more work, since some blocks inconveniently have "start" in them
            Finish = ParseBlocks(_challenge, BlockMode.FINISH);
            Checkpoints = ParseBlocks(_challenge, BlockMode.CHECKPOINT);
            CheckpointNum = _challenge.NbCheckpoints;
            IsMultiLap = _challenge.TMObjective_IsLapRace;
            LapCount = IsMultiLap.GetValueOrDefault() ? _challenge.TMObjective_NbLaps : 0;
            AuthorTime = _challenge.TMObjective_AuthorTime;
        }
        public string? MapName { get; set; }
        public List<CGameCtnBlock>? Start { get; set; }
        public List<CGameCtnBlock>? Finish { get; set; }
        public List<CGameCtnBlock>? Checkpoints { get; set; }
        public int? CheckpointNum { get; set; }
        public bool? IsMultiLap { get; set; }
        public int? LapCount { get; set; }
        public TimeInt32? AuthorTime { get; set; }

        private static List<CGameCtnBlock>? ParseBlocks(CGameCtnChallenge? _challenge, BlockMode mode)
        {
            var y = _challenge?.Blocks?.Where(b => b.Name.ToLower().Contains(mode.ToString().ToLower()));
            return y?.ToList();
        }

        public bool Obeys(TMMapRules? rules) // M8r1x: Free blocks have coords <-1,-1,-1>
        {
            if (rules == null)
                return true;

            if (rules.ForceStart != null)
            {
                if (Start == null) return false; //vallzeh: there is no start, which should yield false if we assume start has forced equality
                var (rules_coord, rules_direction) = rules.ForceStart;
                if (Start == null || Start.Count <= 0) return false;
                if (rules_coord != Start[0].Coord || rules_direction != Start[0].Direction)
                    return false;
            }

            if (rules.ForceFinish != null)
            {
                if (Finish == null) return false; 
                foreach (CGameCtnBlock finish in Finish)
                {
                    foreach(Tuple<Int3, Direction> ruleFinish in rules.ForceFinish) 
                    {
                        var (rules_coord, rules_direction) = ruleFinish;
                        if (rules_coord != finish.Coord || rules_direction != finish.Direction)
                            return false;
                    }
                }
            }

            if (rules.ForceCheckpoint != null)
            {
                if (Checkpoints == null) return false;
                foreach (CGameCtnBlock cp in Checkpoints)
                {
                    foreach (Tuple<Int3, Direction> ruleCheckpoint in rules.ForceCheckpoint)
                    {
                        var (rules_coord, rules_direction) = ruleCheckpoint;
                        if (rules_coord != cp.Coord || rules_direction != cp.Direction)
                            return false;
                    }
                }
            }

            if (rules.ForceCheckpointCount != null)
            {
                var (rules_eq, rules_cpcount) = rules.ForceCheckpointCount;
                switch (rules_eq)
                {
                    case EqMode.LESS_THAN:
                        if (CheckpointNum > rules_cpcount) return false;
                        break;
                    case EqMode.LESS_OR_EQUAL:
                        if (CheckpointNum >= rules_cpcount) return false;
                        break;
                    case EqMode.EQUAL_TO:
                        if (CheckpointNum != rules_cpcount) return false;
                        break;
                    case EqMode.GREATER_THAN:
                        if (CheckpointNum < rules_cpcount) return false;
                        break;
                    case EqMode.GREATER_OR_EQUAL:
                        if (CheckpointNum <= rules_cpcount) return false;
                        break;
                }
            }

            if (rules.ForceAuthorTime != null)
            {
                var (rules_eq, rules_author) = rules.ForceAuthorTime;
                switch (rules_eq)
                {
                    case EqMode.LESS_THAN:
                        if (rules_author > AuthorTime) return false;
                        break;
                    case EqMode.LESS_OR_EQUAL:
                        if (rules_author >= AuthorTime) return false;
                        break;
                    case EqMode.EQUAL_TO: //Don't see a use case for this but 
                        if (rules_author != AuthorTime) return false;
                        break;
                    case EqMode.GREATER_THAN:
                        if (rules_author < AuthorTime) return false;
                        break;
                    case EqMode.GREATER_OR_EQUAL:
                        if (rules_author <= AuthorTime) return false;
                        break;
                }
            }

            if (rules.ForceMultiLap != null)
            {
                if (IsMultiLap == null || IsMultiLap == false) return false;
                if (LapCount != rules.ForceMultiLap) return false;
            }

            return true;
        }
    }
}
