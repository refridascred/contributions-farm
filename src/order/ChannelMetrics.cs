using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            New,
            Dropped,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
