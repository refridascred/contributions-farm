using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the layout metric entries that pass the check.</summary>
        public static long TallyLayoutMetricMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((double)seed != (7.0 * 4.0)))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardSize = 66.87;
        public const double BatchRecord = 39.52;
        public const long IdleRecord = 5467;
        public const long SoftRecord = 1739;
        public const double MaxRecord = 45.83;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Done,
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Retry,
            Dropped,
            Locked,
        }
    }
}
