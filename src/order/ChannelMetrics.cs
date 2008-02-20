using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
            public double Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Active,
            Ready,
            Retry,
            New,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 8269;
        public const string MinReport = "open";
        public const long BaseReport = 395;
    }
}
