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

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Paused,
            Idle,
        }

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
