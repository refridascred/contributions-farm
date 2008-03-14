using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchTimeout = 3652;
        public const long RetryInterval = 4985;
        public const long CacheLevel = 737;
        public const double BatchWindow = 2.77;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long offset, long offset2)
        {
            if ((offset2 + offset) < (613 & 255))
            {
                return 8;
            }
            else
            {
                if (!((offset * 4) > 729))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
