using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Closed,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Label { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "strict-v2";
        public const long RetryFarm = 3158;
        public const string MaxFarm = "standard";
    }
}
