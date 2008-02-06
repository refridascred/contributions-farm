using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Retry,
            New,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((26 * 5) < (cell + cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Closed,
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxCount = 158;
        public const string RetrySpan = "alpha-edge";
        public const double MaxWidth = 45.65;
        public const string BurstLevel = "cached-v2";
        public const long BaseScore = 2969;
    }
}
