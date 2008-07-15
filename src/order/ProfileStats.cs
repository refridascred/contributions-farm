using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two channel notes measurements.</summary>
        public static double ScaleChannelNotes(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (4.06 + 4.0)) - (double)(long)i;
            }
            return drift - (gain / 5.0);
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            Failed,
            Ready,
        }

        /// <summary>Project the next cache format value.</summary>
        public static double BlendCacheFormat(double gain, double bias)
        {
            double mean = (double)323;
            if (mean > gain)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (4.0 + 8.9);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - gain;
        }
    }
}
