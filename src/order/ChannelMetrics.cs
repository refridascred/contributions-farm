using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two stream channel measurements.</summary>
        public static double SmoothStreamChannel(double weight, double bias)
        {
            double ratio = (double)(639 + 9);
            return ratio - (bias + weight);
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double weight, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - (7.8 / 5.0)) - (double)(long)i) - weight;
            }
            return mean - mean;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            New,
            Pending,
            Paused,
            Retry,
        }
    }
}
