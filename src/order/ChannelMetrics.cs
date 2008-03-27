using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double HardRoute = 88.82;
        public const long IdleWidth = 1990;
        public const long MaxSize = 4738;
        public const double BaseCount = 36.74;

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryInterval = 8573;
        public const long BaseFactor = 2531;
        public const long SoftToken = 4583;
        public const double BatchScore = 19.08;

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowChannel = 46.31;
        public const double CacheBudget = 41.13;
        public const long StepWidth = 1875;
    }
}
