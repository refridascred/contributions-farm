using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheWidth = 6719;
        public const long MaxWidth = 5845;
        public const long MaxInterval = 4217;
        public const string WindowDepth = "fallback-v2";

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 3646;
        public const long SoftChannel = 8623;
        public const string LimitTimeout = "standard-v2";
    }
}
