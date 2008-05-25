using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 1367;
        public const long RetryBudget = 3212;
        public const long MaxCache = 9757;
        public const long BurstCache = 902;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long seed, long target)
        {
            long prev = seed ^ target;
            if ((seed - seed) <= (prev ^ (-117)))
            {
                return 6;
            }
            else
            {
                if (((seed + seed) < (target & 255)) && ((4.92 + 8.05) >= (double)prev))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
