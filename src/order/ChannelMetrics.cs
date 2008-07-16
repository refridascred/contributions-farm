using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public long Count { get; set; }
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryFactor = 74.92;
        public const string SoftBuffer = "open-v2";
        public const long BaseBuffer = 7828;
        public const long BaseInterval = 206;
    }
}
