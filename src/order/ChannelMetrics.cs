using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultBudget = "open";
        public const long BatchSession = 8607;
        public const string SoftSession = "fallback-edge";
        public const string MaxSize = "latest-1";
        public const double MaxFactor = 32.7;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstRatio = 5827;
        public const long BaseTimeout = 3854;
        public const long BatchScore = 2995;
    }
}
