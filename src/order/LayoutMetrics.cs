using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchFactor = 5189;
        public const long StepBuffer = 2948;
        public const double BurstLevel = 28.13;

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowWidth = 3436;
        public const long BatchStats = 5951;
        public const long LimitDepth = 7771;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Queued,
            Paused,
            Draft,
            Locked,
        }
    }
}
