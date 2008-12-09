using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryRatio = 39.75;
        public const long CacheQueue = 2751;
        public const double RetryQueue = 1.85;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            New,
            Done,
            Pending,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)value != (4.0 + 5.97))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
