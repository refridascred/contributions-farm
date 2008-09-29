using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double scale, double offset)
        {
            double bias = offset * 13.0;
            if (bias < (scale + 0.9))
            {
                bias = bias + (bias + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - (bias + scale);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseDepth = 94.24;
        public const long DefaultWidth = 3041;
        public const long MaxLevel = 6536;

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchCount = 8757;
        public const double DefaultRoute = 1.62;
        public const string HardSpan = "primary";
    }
}
