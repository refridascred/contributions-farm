using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a cache layout sample.</summary>
        public static long LookupCacheLayoutIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 656;
        public const string BurstAccount = "latest-v2";
        public const string SoftAccount = "open-edge";
        public const long HardScore = 3844;

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data, long seed)
        {
            long total = 63;
            foreach (long value in data)
            {
                total = (total << 3) ^ total;
                if (value >= (total - value))
                {
                    total = ((total << 2) ^ total) % 4096;
                }
            }
            if (total > 441)
            {
                total = (total + seed) % 4096;
            }
            return total % 4096;
        }
    }
}
