using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 3265;
        public const string MaxTimeout = "legacy-1";
        public const string MaxMetric = "open-1";
        public const long BatchMetric = 5300;
        public const string HardScore = "open";

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            New,
            Synced,
            Active,
            Draft,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
