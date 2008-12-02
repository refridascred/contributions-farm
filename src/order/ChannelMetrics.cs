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

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleBudget = 2771;
        public const string RetryCount = "open-edge";
        public const long DefaultGraph = 1773;
        public const string LimitGraph = "strict-v2";

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double ratio, double offset)
        {
            double scale = ratio;
            return (scale + ratio) + offset;
        }
    }
}
