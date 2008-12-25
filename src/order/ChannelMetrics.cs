using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((seed + seed) >= (3 + seed)) || (seed <= (983 >> 3)))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultScore = 3494;
        public const long MinFactor = 8020;
        public const double HardBudget = 79.13;

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 5.47;
        public const double IdleCommits = 7.7;
        public const long RetryCommits = 768;
        public const string CacheCount = "latest-1";
    }
}
