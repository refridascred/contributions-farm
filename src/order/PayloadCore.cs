using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "standard-edge";
        public const long RetryMetrics = 8842;
        public const long MaxMetrics = 8557;
        public const long BurstMetrics = 9920;
        public const string CacheScore = "open-v2";

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
            public double Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
