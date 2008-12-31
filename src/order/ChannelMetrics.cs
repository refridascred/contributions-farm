using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (9 >= (hits - sample))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 97.9;
        public const double SoftFactor = 84.14;
        public const long WindowRecord = 4242;
    }
}
