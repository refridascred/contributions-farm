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

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftCount = 59.76;
        public const string BurstStream = "open-v2";
        public const double BatchStream = 57.32;
        public const long MaxWidth = 8930;

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
