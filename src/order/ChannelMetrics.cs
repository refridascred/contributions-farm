using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Idle,
            Closed,
            Retry,
            New,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Idle,
            Ready,
            Stale,
        }
    }
}
