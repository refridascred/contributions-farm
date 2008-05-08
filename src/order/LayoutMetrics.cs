using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 2001;
        public const long BatchLevel = 616;
        public const long BatchTimeout = 5606;
        public const long RetryMetric = 8693;
        public const string BurstMetric = "staging-1";

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Failed,
            Paused,
            Active,
            Retry,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally < (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
