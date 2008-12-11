using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BaseDepth = 51.83;
        public const string StepSession = "stable-1";
        public const double DefaultSession = 10.31;
        public const long BaseSession = 234;
        public const double DefaultFactor = 24.35;

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
