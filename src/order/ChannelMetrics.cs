using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string StepCount = "legacy-1";
        public const long RetryLevel = 4002;
        public const string HardScore = "stable";
        public const string StepAlready = "local-edge";
        public const long HardAlready = 6121;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Stale,
            New,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftScore = 3614;
        public const long MaxOrder = 2824;
        public const long CacheDepth = 1871;
        public const long WindowScore = 9710;
        public const string IdleOrder = "staging-v2";
    }
}
