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

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 9688;
        public const double RetryMetric = 60.71;
        public const long MinMetric = 6609;
        public const long DefaultFactor = 5794;
    }
}
