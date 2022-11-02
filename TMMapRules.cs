using GBX.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmEssentials;

namespace GbxTest
{
    /// <summary>
    /// Rule set for a TMMapTemplate to obey. 
    /// </summary>
    public class TMMapRules
    {
        public TMMapRules(Tuple<Int3, Direction>? forceStart, List<Tuple<Int3, Direction>>? forceFinish, List<Tuple<Int3, Direction>>? forceCheckpoint, Tuple<EqMode, int>? forceCheckpointCount,
            Tuple<EqMode, int>? forceMultiLap, Tuple<EqMode, TimeInt32>? forceAuthorTime)
        {
            ForceStart = forceStart;
            ForceFinish = forceFinish;
            ForceCheckpoint = forceCheckpoint;
            ForceCheckpointCount = forceCheckpointCount;
            ForceMultiLap = forceMultiLap;
            ForceAuthorTime = forceAuthorTime;
        }

        public Tuple<Int3, Direction>? ForceStart { get; set; }
        public List<Tuple<Int3, Direction>>? ForceFinish { get; set; }
        public List<Tuple<Int3, Direction>>? ForceCheckpoint{ get; set; }
        public Tuple<EqMode, int>? ForceCheckpointCount { get; set; }
        public Tuple<EqMode, int>? ForceMultiLap { get; set; }
        public Tuple<EqMode, TimeInt32>? ForceAuthorTime { get; set; }
    }
}
