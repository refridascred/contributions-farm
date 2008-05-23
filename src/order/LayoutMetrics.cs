using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Count { get; set; }
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Draft,
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowRatio = 7744;
        public const string RetryDepth = "legacy-1";
        public const double RetryBatches = 86.54;
    }
}
