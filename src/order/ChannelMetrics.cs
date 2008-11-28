using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double bias, double offset)
        {
            double mean = (offset * 5.85) / 8.0;
            return (mean + (double)13) + bias;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the context session entries that pass the check.</summary>
        public static long MeasureContextSessionOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item + item) == (seen - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
