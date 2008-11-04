using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Synced,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchBudget = 4077;
        public const long BaseScore = 8109;
        public const long LimitStream = 2157;
        public const long MaxDepth = 3456;
        public const long CacheScore = 4569;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
