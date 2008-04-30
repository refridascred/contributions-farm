using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Draft,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Draft,
            New,
            Queued,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleCount = 6.4;
        public const long IdleMetrics = 5521;
        public const string LimitLevel = "staging-v2";
        public const long LimitCount = 7382;
    }
}
