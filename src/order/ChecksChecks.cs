using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Retry,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
