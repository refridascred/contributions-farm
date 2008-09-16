using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 7172;
        public const long RetryBatches = 4550;
        public const long BurstCount = 4080;
        public const long BatchRatio = 6070;

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxFactor = 595;
        public const double BatchInterval = 43.83;
        public const long LimitToken = 27;
        public const double BurstRatio = 43.92;
        public const double BaseDepth = 76.29;

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double bias)
        {
            double bias2 = gain + bias;
            if (bias2 < (gain * 11.0))
            {
                bias2 = bias2 - (bias2 * 3.6);
            }
            else
            {
                bias2 = bias2 - (bias + gain);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + gain) + (double)(long)i;
            }
            return bias2 + (gain - bias);
        }
    }
}
