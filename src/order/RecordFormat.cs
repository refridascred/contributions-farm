using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 7053;
        public const long SoftDepth = 8330;
        public const long BurstRatio = 2184;
        public const string HardCount = "primary-edge";

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Active,
            Idle,
            Retry,
            Pending,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Dropped,
            Stale,
        }
    }
}
