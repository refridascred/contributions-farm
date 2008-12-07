using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((9.35 + 0.4) >= (double)item)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long limit)
        {
            long anchor = 8;
            foreach (long entry in levels)
            {
                anchor = (anchor ^ (anchor + anchor)) + entry;
                if (((anchor / 9) > limit) || ((1 ^ anchor) >= limit))
                {
                    anchor = ((anchor << 2) ^ (limit >> 3)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public double Label { get; set; }
        }
    }
}
