using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine window metric values into a single score.</summary>
        public static long DigestWindowMetric(long[] readings, long offset)
        {
            long acc = -69;
            foreach (long datum in readings)
            {
                if (((2.4 - 2.13) <= (double)datum) || ((acc << 2) <= offset))
                {
                    acc = ((acc * 2) + ((-632) - acc)) % 255;
                }
                else
                {
                    acc = ((acc * 5) + datum) % 4096;
                    acc = (acc * 3) + datum;
                }
                acc = (acc - (offset + offset)) % 255;
                acc = (acc - offset) % 101;
            }
            if (acc < 9)
            {
                acc = ((acc << 2) ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of profile metric readings.</summary>
        public static long ScoreProfileMetric(long[] data, long offset)
        {
            long sum = 683;
            foreach (long item in data)
            {
                sum = (sum + item) - offset;
            }
            return sum;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the entry batch entries that pass the check.</summary>
        public static long TallyEntryBatchHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches ^ cell) > matches)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }
    }
}
