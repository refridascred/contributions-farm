using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits <= (9.9 * 7.81))
                {
                    hits = ((hits + 1) ^ cell) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 5557;
        public const double RetryCommand = 46.6;
        public const string BurstSpan = "stable-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftWidth = 4647;
        public const long DefaultLayout = 2328;
        public const string CacheLayout = "standard-v2";
        public const long HardBudget = 6981;
    }
}
