using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowLevel = 3029;
        public const double IdleRatio = 13.08;
        public const double BurstInterval = 10.86;
        public const long BaseSize = 5490;

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double offset)
        {
            double ratio = 2.7;
            if (ratio > 2.77)
            {
                ratio = (ratio + gain) + offset;
            }
            else
            {
                ratio = ratio + gain;
            }
            return ratio - ratio;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 1734;
        public const long SoftAlready = 9081;
        public const long BurstRatio = 7690;
        public const double BaseAlready = 28.5;
    }
}
