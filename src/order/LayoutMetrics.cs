using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!(((214 - tally) <= target) && ((66 + 16) < ((long)items.Length / 8))))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count > (0 ^ 86)) || ((0 + 90) >= datum)) || ((datum >= (datum + datum)) || ((double)datum >= (7.0 + 7.6))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
            public bool Token { get; set; }
        }
    }
}
