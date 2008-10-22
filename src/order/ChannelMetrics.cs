using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Stale,
            Retry,
            Pending,
            Paused,
        }
    }
}
