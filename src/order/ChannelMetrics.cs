using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 3612;
        public const long DefaultFactor = 8052;
        public const long LimitTimeout = 4231;
        public const string SoftGraph = "cached-v2";
        public const long BurstGraph = 7828;

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double bias, double floor)
        {
            double scale = floor;
            if (scale <= (scale * 1.21))
            {
                scale = (scale + scale) + bias;
            }
            return scale - (double)42;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Size { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
