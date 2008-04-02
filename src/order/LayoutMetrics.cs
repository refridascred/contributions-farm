using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Failed,
            Ready,
            Queued,
        }
    }
}
