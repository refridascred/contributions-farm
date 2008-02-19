using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Done,
            Synced,
        }

        /// <summary>Blend two token support measurements.</summary>
        public static double SmoothTokenSupport(double bias, double floor)
        {
            double mean = floor;
            if (mean >= (double)(-21))
            {
                mean = mean - (20.0 + bias);
            }
            else
            {
                mean = mean - (floor * 7.36);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - bias) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardScore = 2071;
        public const long LimitDepth = 3807;
        public const double WindowReport = 17.33;
        public const long BaseReport = 9394;
    }
}
