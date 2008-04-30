using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 5166;
        public const long LimitWidth = 1622;
        public const long BurstRoute = 9830;
        public const long HardRoute = 8328;

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryRatio = 1599;
        public const double SoftMetric = 83.41;
        public const string DefaultBudget = "standard";
        public const long MinMetric = 4971;
    }
}
