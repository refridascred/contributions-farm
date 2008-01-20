using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a session cluster reading by value.</summary>
        public static long SeekSessionClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Flag { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double floor)
        {
            double mean = floor;
            if (mean < (mean - mean))
            {
                mean = mean - (mean * 6.13);
            }
            else
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (16.0 * 3.6)) + (double)(long)i;
            }
            return mean - scale;
        }
    }
}
