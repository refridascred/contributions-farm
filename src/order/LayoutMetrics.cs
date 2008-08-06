using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            New,
            Synced,
            Paused,
            Draft,
            Idle,
        }
    }
}
