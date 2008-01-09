using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardFarm = "latest-v2";
        public const string MinSpan = "stable-1";
        public const long MaxDepth = 2922;
        public const long WindowCount = 2018;
        public const double MaxFactor = 0.07;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
