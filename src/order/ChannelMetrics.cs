using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 14.71;
        public const string BurstWidth = "standard";
        public const string RetryTools = "fallback-1";
        public const long BaseTools = 3575;
        public const long MaxRatio = 5361;
    }
}
