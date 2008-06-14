using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultInterval = 8338;
        public const long DefaultChecks = 4991;
        public const double BurstBudget = 6.37;
        public const long MaxChecks = 3782;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Retry,
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Draft,
            Paused,
            Idle,
        }
    }
}
