using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 2114;
        public const double MaxCounter = 65.79;
        public const long HardScore = 7619;
        public const long RetryWidth = 9416;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            Paused,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Paused,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
