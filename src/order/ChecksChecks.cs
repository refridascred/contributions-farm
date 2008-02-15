using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseTimeout = 47.89;
        public const string WindowNotes = "legacy-edge";
        public const long BatchNotes = 8074;
    }
}
