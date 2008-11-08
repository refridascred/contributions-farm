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

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series)
        {
            long mark = 62;
            foreach (long cell in series)
            {
                if (!(cell <= (cell & 127)))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            if (mark < 43)
            {
                mark = (mark + (mark / 6)) % 101;
            }
            return mark % 97;
        }
    }
}
