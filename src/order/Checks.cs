using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            New,
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Paused,
            New,
            Failed,
            Retry,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Label { get; set; }
            public bool Size { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Total { get; set; }
            public long Region { get; set; }
        }
    }
}
