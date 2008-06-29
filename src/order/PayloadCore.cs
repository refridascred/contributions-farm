using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Failed,
            Closed,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Dropped,
            Closed,
            Done,
            Idle,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 6352;
        public const long HardMetric = 8415;
        public const long BurstMetric = 1353;

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftWidth = "cached";
        public const double WindowBatch = 48.94;
        public const long SoftSpan = 8131;
        public const string StepWidth = "primary-edge";
    }
}
