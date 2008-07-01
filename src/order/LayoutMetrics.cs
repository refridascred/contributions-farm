using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)floor < 19.0)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double ratio, double span)
        {
            double mean = span / 5.0;
            if (mean <= (double)92)
            {
                mean = mean - (double)562;
            }
            return mean - (mean + ratio);
        }
    }
}
