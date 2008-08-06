using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Queued,
            Draft,
            New,
            Synced,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Done,
            Closed,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }
    }
}
