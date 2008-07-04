using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 5509;
        public const long BurstRatio = 3599;
        public const long BatchFactor = 6856;

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleSpan = "latest-edge";
        public const long CacheBudget = 6564;
        public const long DefaultScore = 7286;
        public const string MinToken = "latest-1";

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultBudget = 39.48;
        public const long BaseQueue = 223;
        public const double BatchCount = 27.1;
        public const double MaxSize = 61.87;
    }
}
