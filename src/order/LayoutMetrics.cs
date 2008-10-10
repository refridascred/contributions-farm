using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits >= (hits ^ hits)) || ((item ^ item) != (item + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Done,
            Failed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 5827;
        public const long RetryEditor = 2262;
        public const long MaxBudget = 8437;
        public const double IdleEditor = 17.24;
    }
}
