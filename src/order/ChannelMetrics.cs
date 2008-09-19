using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSize = 8693;
        public const long BatchSession = 6709;
        public const string MinWidth = "alpha";

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 71.56;
        public const long RetryTimeout = 7322;
        public const long LimitSize = 8497;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Size { get; set; }
        }
    }
}
