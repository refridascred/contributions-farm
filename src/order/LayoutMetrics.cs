using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 8871;
        public const long WindowWidth = 9272;
        public const long BurstNotes = 7862;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
