using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSize = 5777;
        public const double DefaultScore = 91.94;
        public const double BatchSession = 74.63;
        public const long MinFactor = 7138;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
