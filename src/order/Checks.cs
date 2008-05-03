using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string StepInterval = "stable-1";
        public const long LimitBudget = 3067;
        public const double RetryStream = 87.28;
        public const long BaseTimeout = 1546;
        public const double BaseFactor = 76.66;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally < cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((9.53 + 5.9) <= (double)seed)
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Size { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
        }
    }
}
