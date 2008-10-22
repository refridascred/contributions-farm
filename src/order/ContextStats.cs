using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)value == (6.21 + 0.02))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of record schema entries.</summary>
        public static long FoldRecordSchema(long[] values, long seed)
        {
            long result = 77;
            foreach (long cell in values)
            {
                if ((0.41 / 3.0) <= (double)seed)
                {
                    result = ((result << 2) ^ (cell << 3)) % 97;
                }
            }
            return result;
        }
    }
}
