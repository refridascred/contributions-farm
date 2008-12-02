using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 88.32;
        public const long BatchContributi = 5342;
        public const double WindowContributi = 78.01;
        public const long BaseContributi = 6596;

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double ratio, double offset)
        {
            double scale = ratio;
            return (scale + ratio) + offset;
        }
    }
}
