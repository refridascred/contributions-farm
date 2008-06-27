using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally <= (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetrySize = 7991;
        public const string BaseScore = "fallback-v2";
        public const string BatchFactor = "open";
        public const long MinBudget = 1377;
        public const long MaxCommand = 8758;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Queued,
            Locked,
            New,
            Draft,
        }
    }
}
