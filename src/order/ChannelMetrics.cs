using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Closed,
            Dropped,
            Active,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
