using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 1370;
        public const string SoftBudget = "stable-v2";
        public const long SoftCounter = 7332;
        public const long LimitCount = 7618;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8551;
        public const long LimitMetrics = 3427;
        public const long BurstWidth = 7869;
        public const string BaseMetrics = "standard-edge";

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
