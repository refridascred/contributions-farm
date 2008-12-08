using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Weight { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Rank { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Dropped,
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            New,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Draft,
            Dropped,
            Idle,
            Closed,
        }
    }
}
