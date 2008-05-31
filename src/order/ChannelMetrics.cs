using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinScore = 8226;
        public const long BaseRatio = 1195;
        public const long IdleWindow = 7233;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Failed,
            Draft,
            New,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry <= (entry + entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
