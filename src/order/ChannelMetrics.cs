using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string RetryTimeout = "cached-v2";
        public const string MaxWindow = "primary-1";
        public const long WindowTimeout = 3526;
        public const string CacheWindow = "fallback-edge";

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Queued,
            Paused,
            Done,
            Ready,
        }
    }
}
