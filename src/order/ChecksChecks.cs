using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Dropped,
            Stale,
            Ready,
            New,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Limit { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
