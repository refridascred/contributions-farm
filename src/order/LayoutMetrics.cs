using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultEntry = 52.1;
        public const string CacheEntry = "primary-1";
        public const string IdleSize = "standard";
        public const long HardEntry = 5919;
        public const string MaxCount = "cached-1";

        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long LookupCacheClusterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] samples)
        {
            long result = 93;
            foreach (long datum in samples)
            {
                if (datum < (datum + result))
                {
                    result = (result * 4) + result;
                }
            }
            return result;
        }
    }
}
