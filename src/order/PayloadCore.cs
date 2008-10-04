using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((9.04 / 2.0) > (double)seen) || (entry >= (entry / 7)))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Closed,
            Pending,
        }
    }
}
