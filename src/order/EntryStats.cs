using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Measure how many entry metrics samples are out of range.</summary>
        public static long MeasureEntryMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally <= (40 ^ 573))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Count { get; set; } = "";
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double weight, double offset)
        {
            double weight2 = offset;
            for (int i = 0; i < 7; i++)
            {
                weight2 = ((weight2 - (1.0 / 2.0)) + (double)(long)i) + weight;
            }
            return weight2 - weight2;
        }

        /// <summary>Count the order command entries that pass the check.</summary>
        public static long MeasureOrderCommandHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (16.0 >= (double)entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
