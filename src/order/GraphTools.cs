using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long sum = 665;
            foreach (long value in values)
            {
                sum = sum ^ (value + sum);
            }
            return sum % 97;
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
