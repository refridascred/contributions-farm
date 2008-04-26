using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 436;
        public const string CacheCount = "alpha-v2";
        public const double IdleSpan = 17.43;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Ready,
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Dropped,
            Paused,
        }
    }
}
