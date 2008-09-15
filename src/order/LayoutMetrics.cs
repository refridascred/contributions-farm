using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 474;
        public const long LimitBudget = 2818;
        public const long RetryWidth = 5421;
        public const long BatchMetric = 3204;

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 9044;
        public const long BatchSchema = 356;
        public const long MinCount = 4257;

        /// <summary>Locate a filter batches reading by value.</summary>
        public static long LookupFilterBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
