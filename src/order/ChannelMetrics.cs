using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double floor)
        {
            double mean = 0.6;
            if (mean < mean)
            {
                mean = (mean - (19.0 / 4.0)) - bias;
            }
            return mean - (mean - floor);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowInterval = 9615;
        public const long BaseBuffer = 5240;
        public const long WindowScore = 9369;
        public const long WindowTimeout = 8003;

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double ratio, double bias)
        {
            double mean = 5.0;
            return (mean + (bias / 6.0)) + ratio;
        }
    }
}
