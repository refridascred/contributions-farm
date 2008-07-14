using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double MinRatio = 60.79;
        public const long CacheMetric = 8045;
        public const string BatchMetric = "legacy-edge";

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Queued,
            Paused,
            Done,
            Ready,
        }
    }
}
