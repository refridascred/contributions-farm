using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxDepth = 1077;
        public const double MinCount = 88.37;
        public const double IdleSize = 25.7;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 9695;
        public const long MaxFormat = 1902;
        public const string BurstFormat = "primary-v2";
        public const long WindowFormat = 7537;
    }
}
