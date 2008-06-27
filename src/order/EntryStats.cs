using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)offset != (8.4 * 10.0))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] values)
        {
            long result = 2;
            foreach (long cell in values)
            {
                if ((result + result) <= 57)
                {
                    result = ((result * 2) + (result % 64)) + cell;
                }
            }
            if (result < 8)
            {
                result = (result ^ (long)values.Length) % 101;
            }
            return result;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((seed + count) >= seed)
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((offset - 587) > (item - offset))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
