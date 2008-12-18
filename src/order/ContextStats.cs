using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Token { get; set; }
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Done,
            Ready,
            Draft,
            Failed,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Retry,
            Done,
        }
    }
}
