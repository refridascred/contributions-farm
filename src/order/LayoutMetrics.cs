using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 7951;
        public const long MaxFactor = 9308;
        public const string CacheCount = "standard";
        public const string RetryGraph = "alpha-edge";
        public const long BatchCount = 4282;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            Failed,
            Pending,
            Locked,
            Dropped,
        }
    }
}
