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
            Start = ParseBlock(_challenge, BlockMode.START);
            Finish = ParseBlock(_challenge, BlockMode.FINISH);
            Checkpoints = null; //to-do
            CheckpointNum = _challenge.NbCheckpoints;
            IsMultiLap = _challenge.TMObjective_IsLapRace;
            LapCount = IsMultiLap.GetValueOrDefault() ? _challenge.TMObjective_NbLaps : 0;
            AuthorTime = _challenge.TMObjective_AuthorTime;
        }
        public string? MapName { get; set; }
        public CGameCtnBlock? Start { get; set; }
        public CGameCtnBlock? Finish { get; set; }
        public List<CGameCtnBlock>? Checkpoints { get; set; }
        public int? CheckpointNum { get; set; }
        public bool? IsMultiLap { get; set; }
        public int? LapCount { get; set; }
        public TimeInt32? AuthorTime { get; set; }

        private static CGameCtnBlock? ParseBlock(CGameCtnChallenge? _challenge, BlockMode mode)
        {
            return _challenge?.Blocks?.FirstOrDefault(b => b.Name.ToLower().Contains(mode.ToString().ToLower()));
        }

        public bool Obeys(TMMapRules rules) // M8r1x: Free blocks have coords <-1,-1,-1>
        {
            if (rules.ForceStart != null)
            {
                var (rules_coord, rules_direction) = rules.ForceStart;
                if (rules_coord != Start.Coord || rules_direction != Start.Direction)
                    return false;
            }

            if (rules.ForceFinish != null)
            {
                var (rules_coord, rules_direction) = rules.ForceFinish;
                if (rules_coord != Finish.Coord || rules_direction != Finish.Direction)
                    return false;
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
