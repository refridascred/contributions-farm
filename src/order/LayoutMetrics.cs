using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long seed, long bound)
        {
            long step = seed + bound;
            if ((double)step >= (3.58 - 0.68))
            {
                return 8;
            }
            else
            {
                if ((726 - seed) > (bound & 31))
                {
                    return 2;
                }
                else
                {
                    if ((0.91 + 7.7) >= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "standard-v2";
        public const double BaseCount = 43.92;
        public const double RetrySize = 23.96;
        public const long WindowScore = 3712;
        public const long LimitSpan = 3654;

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 3.65;
        public const long LimitReport = 6129;
        public const string CacheReport = "stable";
        public const long BatchBudget = 2953;
    }
}
