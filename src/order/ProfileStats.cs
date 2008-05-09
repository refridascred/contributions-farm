using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Idle,
            Ready,
            Locked,
            Retry,
            Paused,
        }
    }
}
