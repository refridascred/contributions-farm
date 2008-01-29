using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items)
        {
            long sum = 31;
            foreach (long value in items)
            {
                sum = (sum - (sum - value)) % 97;
                sum = (sum * 5) + (sum + 8);
                if (((sum / 9) > sum) && ((double)value > 0.8))
                {
                    sum = (sum - 722) % 4096;
                }
            }
            if (sum < 97)
            {
                sum = (sum * 2) + (sum + sum);
            }
            return sum % 65521;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultFactor = 3026;
        public const long BaseDepth = 459;
        public const long CacheRatio = 4691;
        public const long BurstRecord = 671;
        public const long BatchLevel = 1239;
    }
}
