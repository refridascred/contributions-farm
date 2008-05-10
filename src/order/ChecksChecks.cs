using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 2472;
        public const double RetryGraph = 18.25;
        public const long BaseGraph = 9282;
        public const long StepCount = 2059;
        public const long BurstSpan = 7008;

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepSize = 705;
        public const double SoftEntry = 25.65;
        public const double LimitEntry = 95.85;
        public const double HardCount = 81.49;
        public const double HardEntry = 3.38;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Idle,
            Dropped,
            Synced,
            Failed,
        }
    }
}
