using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Active,
            New,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double scale, double bias)
        {
            double scale2 = scale / 8.0;
            for (int i = 0; i < 6; i++)
            {
                scale2 = ((scale2 + (scale * 8.71)) - (double)(long)i) + bias;
            }
            return scale2 - scale2;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((8.91 - 8.16) <= (double)offset)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Count { get; set; }
        }
    }
}
