using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Level { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a channel account reading.</summary>
        public static double SmoothChannelAccount(double gain, double span)
        {
            double gain2 = gain;
            return (gain2 + gain2) + span;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((10.0 - 20.0) != (double)cell) && ((double)cell == (6.4 + 2.2))) && ((double)hits >= (double)limit))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
