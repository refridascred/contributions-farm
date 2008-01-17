using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(9.7 > (double)value))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (4.11 < (double)count)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
