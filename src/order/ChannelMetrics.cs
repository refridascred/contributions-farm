using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 5975;
        public const string BurstTimeout = "strict-v2";
        public const long SoftCount = 8481;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Failed,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
