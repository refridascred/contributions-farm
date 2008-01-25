using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double scale = (gain / 9.0) - (bias + gain);
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (scale * 8.9)) - (double)(long)i;
            }
            return scale - 9.67;
        }

        /// <summary>Adjust a payload batch reading.</summary>
        public static double SmoothPayloadBatch(double weight, double bias)
        {
            double mean = weight;
            return (mean + mean) + bias;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultEntry = 68.93;
        public const string BurstSpan = "primary-v2";
        public const long SoftEntry = 8933;
    }
}
