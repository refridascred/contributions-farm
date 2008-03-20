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

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Active,
            Closed,
            Ready,
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
