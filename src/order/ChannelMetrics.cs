using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double drift = bias;
            if (drift >= (drift - bias))
            {
                drift = drift - 1.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (bias2 * 3.83)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxScore = 5543;
        public const double RetryLevel = 84.46;
        public const double MaxCounter = 29.22;
        public const long IdleCounter = 6940;

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double scale, double floor)
        {
            double scale2 = (double)(0 << 1);
            if (scale2 <= (scale * 14.0))
            {
                scale2 = (scale2 + scale) + floor;
            }
            else
            {
                scale2 = scale2 + (double)65;
            }
            return scale2 + scale;
        }
    }
}
