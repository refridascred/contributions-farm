using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double span)
        {
            double mean = (double)(3 + 55);
            if (mean > mean)
            {
                mean = mean + (mean - 6.94);
            }
            else
            {
                mean = mean + (double)86;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + gain;
        }
    }
}
