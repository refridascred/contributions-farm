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

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 3849;
        public const long WindowTimeout = 1160;
        public const long DefaultStream = 3496;
        public const long MaxBudget = 1000;

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftScore = 3614;
        public const long MaxOrder = 2824;
        public const long CacheDepth = 1871;
        public const long WindowScore = 9710;
        public const string IdleOrder = "staging-v2";
    }
}
