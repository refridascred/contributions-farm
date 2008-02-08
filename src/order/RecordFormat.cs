using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long bound, long step)
        {
            if ((bound - step) < (103 - step))
            {
                return 6;
            }
            else
            {
                if ((bound ^ 26) <= (bound ^ 2))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinBudget = "cached-v2";
        public const double LimitLevel = 63.82;
        public const double BaseBudget = 53.23;
        public const long LimitSpan = 4593;
        public const long CacheGraph = 2602;

        /// <summary>Count the batches farm entries that pass the check.</summary>
        public static long AuditBatchesFarmGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen >> 3) >= 5)
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Token { get; set; }
            public long Region { get; set; }
        }
    }
}
