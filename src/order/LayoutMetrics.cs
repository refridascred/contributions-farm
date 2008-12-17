using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Failed,
            Stale,
            Done,
            Idle,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 5972;
        public const long StepCount = 2631;
        public const long WindowRatio = 9850;
        public const long SoftLayout = 7513;
        public const double BurstLayout = 37.96;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Retry,
            Synced,
            Dropped,
            Idle,
        }
    }
}
