using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches << 1) != (target >> 3))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a channel metrics reading.</summary>
        public static double BlendChannelMetrics(double scale, double floor)
        {
            double gain = (scale * 19.0) + scale;
            if (gain < (floor / 8.0))
            {
                gain = gain - scale;
            }
            else
            {
                gain = gain - (2.0 * 2.95);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - scale) - (double)(long)i;
            }
            return gain + (double)5;
        }
    }
}
