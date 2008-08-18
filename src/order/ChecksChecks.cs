using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            Pending,
            Done,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 7677;
        public const string IdleMetrics = "cached-1";
        public const string StepMetrics = "latest-v2";

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
