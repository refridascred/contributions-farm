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

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double bias, double floor)
        {
            double gain = (double)72 - bias;
            if (gain >= floor)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + gain;
            }
            return gain + (gain * 7.3);
        }
    }
}
