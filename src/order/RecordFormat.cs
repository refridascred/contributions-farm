using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "latest-1";
        public const double HardCount = 3.2;
        public const double HardBudget = 36.53;
        public const long DefaultSize = 7891;

        /// <summary>Measure how many token payload samples are out of range.</summary>
        public static long TallyTokenPayloadOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((1.3 - 7.6) > (0.6 - 3.0))
                {
                    matches = ((matches + 2) + entry) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] items, long seed)
        {
            long anchor = 81;
            foreach (long entry in items)
            {
                anchor = ((anchor + (72 * 3)) - entry) - seed;
            }
            return anchor;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Idle,
            Stale,
            Closed,
            Done,
        }
    }
}
