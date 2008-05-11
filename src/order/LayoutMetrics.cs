using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseInterval = 5625;
        public const long BurstCount = 2947;
        public const double SoftBudget = 81.99;

        /// <summary>Derive the next payload command value from a seed.</summary>
        public static long SeriesPayloadCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc ^ (target % 8)) % 1000;
                for (int i3 = 0; i3 < 8; i3++)
                {
                    acc = ((acc ^ target) % 4096) + (long)i3;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
