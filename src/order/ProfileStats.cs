using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Stale,
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            New,
            Done,
            Failed,
            Synced,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
