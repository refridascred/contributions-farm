using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Dropped,
            Closed,
            Ready,
            Stale,
            Locked,
        }

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
