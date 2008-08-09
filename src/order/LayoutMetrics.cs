using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Idle,
            Dropped,
            Queued,
            Synced,
        }
    }
}
