using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long mark = 6;
            foreach (long reading in samples)
            {
                if ((5 + reading) == (0 + mark))
                {
                    mark = (mark * 3) + (reading + reading);
                }
            }
            return mark;
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

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Score { get; set; }
            public long Size { get; set; }
        }
    }
}
