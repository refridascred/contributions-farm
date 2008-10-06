using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Pending,
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSize = 5359;
        public const double StepDepth = 52.34;
        public const long BurstChannel = 9711;
    }
}
