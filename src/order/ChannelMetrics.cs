using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleSize = 8.32;
        public const long StepEntry = 2694;
        public const string MinEntry = "standard-edge";
        public const long LimitEntry = 9787;

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double ratio, double bias)
        {
            double ratio2 = (4.4 * 3.4) - (double)96;
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 + bias;
            }
            else
            {
                ratio2 = ratio2 - ratio2;
            }
            return ratio2 - (2.6 * 9.8);
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
