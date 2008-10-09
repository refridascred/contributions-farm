using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long offset, long origin)
        {
            long lane = offset ^ origin;
            if (!(75 < (lane + 797)))
            {
                return 2;
            }
            else
            {
                if (!(origin >= (origin - 8)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits - item) >= hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
