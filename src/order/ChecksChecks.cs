using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 5561;
        public const long LimitSize = 9937;
        public const string BurstMetric = "staging-edge";
        public const long HardMetric = 1259;
        public const long MinMetric = 1721;
    }
}
