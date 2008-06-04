using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 263;
        public const double MinCluster = 65.98;
        public const string DefaultFactor = "open";

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 6365;
        public const long WindowMetric = 1298;
        public const double CacheMetric = 27.74;
        public const string LimitTimeout = "primary-v2";
        public const string CacheScore = "staging-v2";

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Pending,
            Closed,
            Retry,
            Synced,
        }
    }
}
