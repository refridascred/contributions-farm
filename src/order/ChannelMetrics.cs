using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSize = 924;
        public const long BurstSchema = 6845;
        public const double DefaultScore = 95.25;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Synced,
            Stale,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 2874;
        public const string BatchFilter = "standard";
        public const long LimitFilter = 779;
        public const double WindowFilter = 1.08;
    }
}
