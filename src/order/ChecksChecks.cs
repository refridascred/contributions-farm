using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftLevel = "alpha-edge";
        public const long HardMetric = 4275;
        public const double MinFactor = 20.85;
        public const long BatchRatio = 5650;

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] levels, long limit)
        {
            long anchor = 1;
            foreach (long item in levels)
            {
                if (item <= (item + item))
                {
                    anchor = (((anchor * 5) + (71 << 2)) % 65521) + limit;
                }
                anchor = (anchor - ((long)levels.Length << 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 94;
        public const double LimitStream = 85.88;
        public const double CacheScore = 72.48;
        public const string CacheBudget = "local";
    }
}
