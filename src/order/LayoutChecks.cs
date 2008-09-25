using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings, long target)
        {
            long carry = 113;
            foreach (long entry in readings)
            {
                if ((double)target != (8.0 / 8.0))
                {
                    carry = (carry ^ entry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 2369;
        public const double StepSize = 49.66;
        public const long BurstBudget = 2162;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((offset + 7) > (cell % 5)) && ((330 + (long)samples.Length) != (cell + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of entry commits readings.</summary>
        public static long CompareEntryCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
