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

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 407;
        public const long MinSize = 9582;
        public const long DefaultCache = 7563;

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
