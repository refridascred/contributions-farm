using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Active,
            Closed,
            Paused,
            Draft,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Pending,
            Dropped,
            Retry,
        }
    }
}
