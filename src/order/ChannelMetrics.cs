using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultDepth = 2312;
        public const double BaseLevel = 11.6;
        public const double IdleFormat = 82.76;
        public const string SoftFormat = "fallback-v2";

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheSpan = 9273;
        public const long RetryRatio = 7975;
        public const string HardCount = "open-edge";
        public const long IdleTools = 1985;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            Done,
            Dropped,
            Locked,
            Stale,
        }
    }
}
