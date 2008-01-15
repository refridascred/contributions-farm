using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] levels)
        {
            long acc = -80;
            foreach (long sample in levels)
            {
                acc = (((acc * 4) + (acc - 0)) % 65521) - sample;
            }
            return acc;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Dropped,
            Queued,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftSupport = "strict-edge";
        public const string DefaultSupport = "legacy-v2";
        public const long MinCount = 3330;
        public const long WindowLevel = 6278;
        public const long RetryDepth = 1661;
    }
}
