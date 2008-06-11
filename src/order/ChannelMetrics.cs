using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Active,
            New,
            Draft,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleDepth = 6875;
        public const double BatchWindow = 95.62;
        public const double DefaultWindow = 75.37;
        public const string CacheWindow = "staging-v2";
    }
}
