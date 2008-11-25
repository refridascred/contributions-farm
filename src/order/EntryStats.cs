using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Paused,
            Pending,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 11.98;
        public const long StepInterval = 1796;
        public const long SoftFormat = 7059;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Done,
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 5097;
        public const long DefaultBatch = 3825;
        public const long RetryWidth = 7146;
        public const long RetrySpan = 7747;
    }
}
