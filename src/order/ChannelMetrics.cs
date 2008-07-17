using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 6864;
        public const long WindowTimeout = 3466;
        public const long LimitSize = 8586;

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 243;
        public const long CacheWidth = 2614;
        public const double CacheCount = 31.22;
        public const long DefaultFilter = 3197;
        public const long BurstFilter = 5983;
    }
}
