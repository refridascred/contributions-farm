using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "staging-edge";
        public const string MinFactor = "stable-v2";
        public const string SoftScore = "cached-1";
        public const long RetryContext = 1312;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Active,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRecord = 81.03;
        public const string BurstRecord = "fallback";
        public const long WindowFactor = 8417;
        public const string RetryRecord = "staging-edge";
        public const string LimitRecord = "open-v2";
    }
}
