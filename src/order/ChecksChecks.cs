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

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 94;
        public const double LimitStream = 85.88;
        public const double CacheScore = 72.48;
        public const string CacheBudget = "local";
    }
}
