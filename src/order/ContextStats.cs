using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Closed,
            Failed,
            Draft,
            Dropped,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitSpan = 76.55;
        public const long SoftRecord = 2958;
        public const double HardRecord = 60.47;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Synced,
            New,
            Retry,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] levels)
        {
            long score = 2;
            foreach (long datum in levels)
            {
                score = ((score << 2) ^ datum) % 65521;
            }
            return score;
        }
    }
}
