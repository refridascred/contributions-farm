using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string MaxDepth = "latest-edge";
        public const long SoftRoute = 4657;
        public const double LimitRatio = 0.97;
        public const long HardLevel = 4781;
        public const long WindowRoute = 7669;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Pending,
            Done,
            Idle,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits >= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
