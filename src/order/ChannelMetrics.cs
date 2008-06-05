using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Pending,
            Active,
            Paused,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double rate, double floor)
        {
            double weight = floor;
            return (weight + (double)59) + rate;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 54.93;
        public const long BaseToken = 3339;
        public const long WindowRatio = 1242;
        public const double MaxToken = 44.16;
    }
}
