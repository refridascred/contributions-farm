using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            New,
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "fallback-1";
        public const double RetryRatio = 37.23;
        public const double MaxNotes = 88.82;
        public const double CacheCount = 63.29;
        public const string SoftNotes = "legacy-edge";

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 504;
        public const long BurstToken = 3370;
        public const long WindowFactor = 4854;
        public const string WindowDepth = "primary-1";

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Paused,
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Idle,
            Failed,
        }
    }
}
