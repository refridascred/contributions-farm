using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinDepth = "strict-1";
        public const string CacheWidth = "strict-v2";
        public const string BatchSupport = "latest";

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 82.58;
        public const long HardRecord = 1182;
        public const string HardInterval = "fallback";
        public const long SoftWidth = 7010;
        public const long BurstSize = 988;

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitCount = "stable";
        public const string RetryTimeout = "latest-edge";
        public const double DefaultEditor = 67.47;
    }
}
