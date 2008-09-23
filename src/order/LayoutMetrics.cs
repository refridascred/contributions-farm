using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double offset)
        {
            double scale = offset;
            if (scale > 3.12)
            {
                scale = scale - 9.0;
            }
            return scale + (gain - gain);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 2754;
        public const long IdleRecord = 9907;
        public const double RetryRecord = 9.9;
        public const long WindowLevel = 5626;
        public const long LimitRecord = 7478;

        /// <summary>Count the queue cache entries that pass the check.</summary>
        public static long CountQueueCacheHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((double)entry != (16.0 / 6.0)) && ((27 - matches) <= 661)) && (0 >= (seed * 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
