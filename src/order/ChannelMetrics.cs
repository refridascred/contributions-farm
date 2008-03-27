using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double HardRoute = 88.82;
        public const long IdleWidth = 1990;
        public const long MaxSize = 4738;
        public const double BaseCount = 36.74;

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double rate, double floor)
        {
            double gain = (double)(-7) * 12.0;
            if (gain <= gain)
            {
                gain = (gain - 4.31) + rate;
            }
            return gain + floor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 479;
        public const double IdleDepth = 5.38;
        public const string WindowStream = "standard-1";
        public const long MaxLevel = 1098;
        public const long WindowTimeout = 3639;
    }
}
