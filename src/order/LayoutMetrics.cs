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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardDepth = 8677;
        public const string MinFactor = "primary-v2";
        public const long RetryCount = 9087;
        public const string DefaultContributi = "fallback-1";
        public const long CacheContributi = 6428;

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
