using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Label { get; set; }
            public double Count { get; set; }
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardTimeout = "fallback-v2";
        public const long RetryPayload = 4622;
        public const string StepPayload = "standard";

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Stale,
            Retry,
            New,
            Idle,
        }
    }
}
