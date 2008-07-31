using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            New,
            Failed,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Failed,
            Pending,
            Synced,
            Active,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
        }
    }
}
