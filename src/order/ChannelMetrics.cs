using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 95.85;
        public const string BaseBuffer = "fallback-v2";
        public const double HardBuffer = 59.22;
        public const string IdleBudget = "stable";

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double weight, double span)
        {
            double gain = (double)(60 ^ (-51));
            if (gain < gain)
            {
                gain = ((gain + 6.8) - weight) + span;
            }
            return gain - (gain * 5.0);
        }
    }
}
