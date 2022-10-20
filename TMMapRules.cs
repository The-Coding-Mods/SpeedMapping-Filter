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
        /// <summary>
        /// It is expected that a rule that isn't enforced is set to null
        /// </summary>
        /// <param name="forceStart"></param>
        /// <param name="forceFinish"></param>
        /// <param name="forceCheckpointCount"></param>
        /// <param name="forceMultiLap"></param>
        /// <param name="forceAuthorTime"></param>
        public TMMapRules(Tuple<Int3, Direction>? forceStart, Tuple<Int3, Direction>? forceFinish, Tuple<EqMode, int>? forceCheckpointCount,
            int? forceMultiLap, Tuple<EqMode, TimeInt32>? forceAuthorTime)
        {
            ForceStart = forceStart;
            ForceFinish = forceFinish;
            ForceCheckpointCount = forceCheckpointCount;
            ForceMultiLap = forceMultiLap;
            ForceAuthorTime = forceAuthorTime;
        }

        public Tuple<Int3, Direction>? ForceStart { get; set; }
        public Tuple<Int3, Direction>? ForceFinish { get; set; }
        public Tuple<EqMode, int>? ForceCheckpointCount { get; set; }
        public int? ForceMultiLap { get; set; }
        public Tuple<EqMode, TimeInt32>? ForceAuthorTime { get; set; }
    }
}
