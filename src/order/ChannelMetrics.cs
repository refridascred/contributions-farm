using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Level { get; set; }
            public double Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double weight, double floor)
        {
            double gain = (weight + weight) * 5.0;
            if (gain < 3.68)
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain - (floor + 0.8);
            }
            return gain + gain;
        }
    }
}
