using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 4561;
        public const long StepLevel = 2674;
        public const string BaseLevel = "latest-v2";
        public const string HardRoute = "alpha-edge";
    }
}
