using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultDepth = "latest-edge";
        public const long DefaultWidth = 4220;
        public const long SoftLevel = 7837;
        public const string SoftStats = "cached-v2";
        public const long RetryInterval = 5498;

        /// <summary>Derive the next window metrics value from a seed.</summary>
        public static long IterateWindowMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                sum = sum - (1 * 3);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((-364) - 28) >= value)
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 32.01;
        public const double WindowRecord = 6.07;
        public const string LimitDepth = "fallback-v2";
    }
}
