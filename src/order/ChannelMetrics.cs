using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

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
