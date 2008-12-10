using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 4997;
        public const long BatchBudget = 9795;
        public const string SoftToken = "stable-1";
        public const long LimitTimeout = 6009;
        public const string MaxInterval = "fallback-v2";

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Failed,
            Stale,
            Paused,
            New,
        }
    }
}
