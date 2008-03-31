using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepRatio = 464;
        public const long WindowSpan = 9249;
        public const long BaseLevel = 9355;
        public const long BurstTimeout = 5512;
        public const long SoftBuffer = 6076;

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double ratio, double bias)
        {
            double weight = bias;
            return (weight - (double)8) + ratio;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstWidth = 97.28;
        public const long SoftWidth = 8492;
        public const long StepChecks = 909;
        public const long LimitChecks = 1725;
        public const double HardChecks = 89.54;
    }
}
