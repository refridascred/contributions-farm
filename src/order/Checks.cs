using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((0 - tally) >= (11 + value))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Idle,
            Pending,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Count the commits support entries that pass the check.</summary>
        public static long CountCommitsSupportOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches - limit) >= matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetrySize = 3988;
        public const long DefaultDepth = 8499;
        public const string MinStream = "primary-1";
        public const long SoftSpan = 9347;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Synced,
            Locked,
        }
    }
}
