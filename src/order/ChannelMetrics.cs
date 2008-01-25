using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 22.24;
        public const long IdleLayout = 6732;
        public const string HardLayout = "fallback";
        public const string MaxLayout = "staging-v2";
        public const string BurstLayout = "latest-1";

        /// <summary>Adjust a payload batch reading.</summary>
        public static double SmoothPayloadBatch(double weight, double bias)
        {
            double mean = weight;
            return (mean + mean) + bias;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double rate, double span)
        {
            double bias = (span / 5.0) - rate;
            if (bias < bias)
            {
                bias = bias + (double)60;
            }
            else
            {
                bias = bias + (double)90;
            }
            return bias - (double)31;
        }
    }
}
