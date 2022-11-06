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
        public readonly bool ValidTemplate = true;
        private bool MustHaveCheckpoint = false;
        public TMMapTemplate(CGameCtnChallenge _challenge)
        {
            MapName = _challenge.MapName;
            Start = ParseBlocks(_challenge, BlockMode.START);
            if (Start == null || Start.Count <= 0) ValidTemplate = false;
            Finish = ParseBlocks(_challenge, BlockMode.FINISH);
            if (Finish == null || Finish.Count <= 0) ValidTemplate = false;
            if (Finish != null && Finish.Where(block => block.Name.Contains("Multilap")).ToList().Count > 0) MustHaveCheckpoint = true;
            Checkpoints = ParseBlocks(_challenge, BlockMode.CHECKPOINT);
            if (Checkpoints == null || (Checkpoints.Count <= 0 && MustHaveCheckpoint)) ValidTemplate = false;
            CheckpointNum = _challenge.NbCheckpoints;
            IsMultiLap = _challenge.TMObjective_IsLapRace;
            LapCount = IsMultiLap.GetValueOrDefault() ? _challenge.TMObjective_NbLaps : 0;
            AuthorTime = _challenge.TMObjective_AuthorTime;
            IncludedPlatformTypes = GetPlatformTypes(_challenge);
        }
        public string? MapName { get; set; }
        public List<CGameCtnBlock>? Start { get; set; }
        public List<CGameCtnBlock>? Finish { get; set; }
        public List<CGameCtnBlock>? Checkpoints { get; set; }
        public int? CheckpointNum { get; set; }
        public bool? IsMultiLap { get; set; }
        public int? LapCount { get; set; }
        public TimeInt32? AuthorTime { get; set; }
        public List<string>? IncludedPlatformTypes { get; set; } 


        private static List<CGameCtnBlock>? ParseBlocks(CGameCtnChallenge? _challenge, BlockMode mode)
        {
            switch (mode)
            {
                case BlockMode.START:
                    var start = _challenge?.Blocks?.Where(block => TMDefinitions.PLATFORM_STARTS.Contains(block.Name)).ToList();
                    if (start == null || start.Count == 0) 
                    {
                        var multilap = _challenge?.Blocks?.Where(block => block.Name.Contains("Multilap")).ToList();
                        return multilap != null && multilap.Count == 1 ? multilap : null; 
                    }
                    return start;

                case BlockMode.FINISH:
                    return _challenge?.Blocks?.Where(block => block.Name.Contains("Finish") || block.Name.Contains("Multilap")).ToList(); 
                default:
                    return _challenge?.Blocks?.Where(block => block.Name.ToLower().Contains(mode.ToString().ToLower())).ToList();
            }
        }

        private static List<string> GetPlatformTypes(CGameCtnChallenge? _challenge)
        {
            List<string> types = new();
            for(int i = 0; i < _challenge?.Blocks?.Count; i++)
            {
                var block = _challenge.Blocks[i];
                if (block == null) continue;
                foreach (var type in TMDefinitions.PLATFORM_TYPES)
                {
                    if(block.Name.Contains(type) && !types.Contains(type))
                        types.Add(type);
                }
            }
            return types;
        }

        private bool IncludesBlockType(List<string> disallowedTypes)
        {
            foreach(var disallowedType in disallowedTypes)
            {
                if (IncludedPlatformTypes == null) return false;
                if (IncludedPlatformTypes.Contains(disallowedType))
                    return true;
            }
            return false;
        }

        public bool Obeys(TMMapRules? rules) // M8r1x: Free blocks have coords <-1,-1,-1>
        {
            if (rules == null)
                return true;

            if (rules.DisallowedBlockTypes != null)
                if (IncludesBlockType(rules.DisallowedBlockTypes)) return false;

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
                    case EqMode.EQUAL_TO: //Don't see a use case for this but ¯\_(ツ)_/¯
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
                var (rules_eq, rules_multilap) = rules.ForceMultiLap;
                int lap = LapCount ?? 0;
                if (rules_multilap > 0 && LapCount == 0) return false;
                switch(rules_eq)
                {
                    case EqMode.LESS_THAN:
                        if (lap >= rules_multilap) return false;
                        break;
                    case EqMode.LESS_OR_EQUAL:
                        if (lap > rules_multilap) return false;
                        break;
                    case EqMode.EQUAL_TO:
                        if (lap != rules_multilap) return false;
                        break;
                    case EqMode.GREATER_THAN:
                        if (lap <= rules_multilap) return false;
                        break;
                    case EqMode.GREATER_OR_EQUAL:
                        if (lap < rules_multilap) return false;
                        break;
                }
            }

            return true;
        }
    }
}
