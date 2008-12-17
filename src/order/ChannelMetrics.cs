using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Done,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheBudget = 5126;
        public const long HardSize = 14;
        public const long MaxCount = 7171;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
