using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Failed,
            Synced,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Stamp { get; set; }
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Closed,
            Ready,
            New,
            Locked,
        }
    }
}
