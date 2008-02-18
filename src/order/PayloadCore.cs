using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Synced,
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Active,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxLevel = 6462;
        public const long DefaultBatch = 9522;
        public const string LimitFactor = "open-1";
        public const long MinBatch = 6926;
        public const long IdleLevel = 5425;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Idle,
            Draft,
            Failed,
            Paused,
            Synced,
        }
    }
}
