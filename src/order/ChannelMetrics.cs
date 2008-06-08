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

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double rate, double span)
        {
            double scale = span / 6.0;
            if (scale <= rate)
            {
                scale = scale - (double)0;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (span + rate)) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
