using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Stale,
            Ready,
            Queued,
            Dropped,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Retry,
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public long Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 315;
        public const long LimitScore = 1030;
        public const long StepBudget = 8502;
    }
}
