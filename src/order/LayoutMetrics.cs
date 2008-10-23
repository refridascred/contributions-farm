using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardRatio = 2939;
        public const double RetrySize = 85.02;
        public const long HardRecord = 9811;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + (-448)) == (item - hits))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 920;
        public const long WindowLevel = 5080;
        public const double LimitFarm = 52.03;
        public const long HardFarm = 9145;
        public const double IdleDepth = 24.19;
    }
}
