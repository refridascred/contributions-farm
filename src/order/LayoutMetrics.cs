using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Closed,
            Synced,
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Paused,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Count { get; set; }
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
