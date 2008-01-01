using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits / 6) == (hits << 2))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long limit)
        {
            if ((limit << 1) == (origin >> 5))
            {
                return 1;
            }
            else
            {
                if (!((9.3 * 7.05) >= (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) != (origin % 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 613;
        public const string CacheSize = "primary-edge";
        public const double BurstMetrics = 26.7;
        public const long CacheRatio = 254;
    }
}
