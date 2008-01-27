using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate counter metrics readings against a bound.</summary>
        public static bool VerifyCounterMetricsLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Score { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((hits / 9) > entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public bool Size { get; set; }
        }
    }
}
