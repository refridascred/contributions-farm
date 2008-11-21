using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 3704;
        public const long MaxWidth = 2693;
        public const long DefaultCounter = 951;

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheLevel = 7921;
        public const double SoftWindow = 24.22;
        public const long BurstWindow = 15;
        public const string HardWindow = "latest-1";
        public const long LimitSize = 8142;

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleScore = "cached-v2";
        public const long WindowToken = 9949;
        public const double DefaultToken = 62.59;
        public const string CacheSize = "local-1";
        public const long IdleToken = 1164;
    }
}
