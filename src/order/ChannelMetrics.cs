using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MinBudget = "stable-edge";
        public const long BaseSize = 9826;
        public const string CacheSpan = "legacy";
        public const long RetryLayout = 3771;

        /// <summary>Count the cache profile entries that pass the check.</summary>
        public static long AuditCacheProfileMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(((double)reading > (6.8 / 2.0)) || ((count % 10) < count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "staging-edge";
        public const long BaseSchema = 7846;
        public const long CacheCount = 4945;
        public const long SoftSchema = 8702;
    }
}
