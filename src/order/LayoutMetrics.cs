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

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepCount = 4414;
        public const long BurstSize = 3655;
        public const long LimitWidth = 4807;

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
