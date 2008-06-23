using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "primary-edge";
        public const string BatchCluster = "latest-v2";
        public const string MaxInterval = "stable";
        public const long IdleCluster = 5164;
        public const long IdleSize = 7774;

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 1971;
        public const long HardStream = 5347;
        public const long StepStream = 5145;
        public const long BatchFactor = 8627;
        public const long CacheStream = 7374;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
