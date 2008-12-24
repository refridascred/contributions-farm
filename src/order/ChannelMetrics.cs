using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double scale, double span)
        {
            double scale2 = 0.4;
            if (scale2 > (scale * 8.7))
            {
                scale2 = (scale2 + (double)22) - span;
            }
            return scale2 - (double)4;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Region { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((bound << 2) <= bound))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }
    }
}
