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

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 1072;
        public const long LimitFactor = 1887;
        public const long DefaultTimeout = 4240;
        public const double BatchWidth = 66.72;
        public const long WindowNotes = 49;
    }
}
