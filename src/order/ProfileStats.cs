using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Stale,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Region { get; set; }
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 4243;
        public const long SoftEditor = 4317;
        public const string MinEditor = "latest-1";
        public const double DefaultCount = 26.37;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Active,
            Closed,
            Pending,
        }
    }
}
