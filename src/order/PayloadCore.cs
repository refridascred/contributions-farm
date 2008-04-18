using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheRatio = 22;
        public const long CacheFilter = 2774;
        public const string RetryFilter = "fallback";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstBudget = 6912;
        public const double MaxMetrics = 27.95;
        public const long SoftDepth = 7819;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Closed,
            Synced,
        }
    }
}
