using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Active,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowSize = 17.49;
        public const string CacheLevel = "latest";
        public const long HardLayout = 1311;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Paused,
            Stale,
        }
    }
}
