using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }

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
