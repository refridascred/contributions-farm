using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxTimeout = 81.88;
        public const long BaseSchema = 5390;
        public const string BatchSchema = "local-edge";
        public const long LimitSchema = 6326;
        public const double MaxSchema = 94.28;

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
