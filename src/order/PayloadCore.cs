using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Dropped,
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Locked,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Dropped,
            Active,
        }
    }
}
