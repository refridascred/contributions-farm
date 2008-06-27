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

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Region { get; set; } = "";
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix + (mix << 2)) % 97;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
