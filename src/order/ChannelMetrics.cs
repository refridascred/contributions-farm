using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((((reading + count) < (952 - offset)) && ((4.5 / 7.0) >= (double)reading)) && ((6.83 * 11.0) == (double)offset))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell > (count ^ cell))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Flag { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
            public double Total { get; set; }
        }
    }
}
