using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchFactor = "standard";
        public const long DefaultScore = 8354;
        public const long StepGraph = 7828;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Closed,
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowLevel = 47.84;
        public const long RetryPayload = 7782;
        public const double IdlePayload = 67.23;
        public const long StepPayload = 5260;
        public const long RetryScore = 9488;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Draft,
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
        }
    }
}
