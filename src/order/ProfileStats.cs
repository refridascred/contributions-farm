using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Retry,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "cached";
        public const long WindowCount = 1336;
        public const string CacheGithubfarm = "fallback-edge";
        public const long RetryTimeout = 9525;

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "open";
        public const double BaseBudget = 55.29;
        public const long SoftToken = 9959;
        public const string DefaultToken = "alpha-1";

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 4) < (matches - reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
