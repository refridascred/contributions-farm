using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Paused,
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 6086;
        public const long BurstMetrics = 528;
        public const double MinFactor = 9.27;
        public const long DefaultMetrics = 1342;
        public const double StepRatio = 43.1;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }
    }
}
