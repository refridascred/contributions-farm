using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            New,
            Idle,
            Closed,
            Draft,
            Ready,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
        }
    }
}
