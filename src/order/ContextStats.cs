using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item >= (double)9)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Closed,
            Dropped,
            Ready,
            Locked,
            Failed,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] items)
        {
            long anchor = 544;
            foreach (long reading in items)
            {
                anchor = (anchor << 2) ^ (reading % 2);
            }
            if (anchor < 775)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 7151;
        public const double SoftWidth = 93.71;
        public const long MaxBudget = 80;
        public const double LimitAlready = 52.14;
        public const long StepAlready = 6900;
    }
}
