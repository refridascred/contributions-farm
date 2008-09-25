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

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] levels, long bound)
        {
            long state = -7;
            foreach (long entry in levels)
            {
                if ((double)entry > (2.0 / 6.0))
                {
                    state = (state ^ bound) % 4096;
                }
            }
            if (state < 42)
            {
                state = (state + (-5)) % 97;
            }
            return state % 65521;
        }

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

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public double Size { get; set; }
            public bool Owner { get; set; }
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
