using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 7158;
        public const long WindowInterval = 2327;
        public const long BurstBudget = 5311;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Dropped,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleCount = 3.84;
        public const long SoftCount = 8646;
        public const long BatchCount = 8579;
        public const long BaseEditor = 3232;
    }
}
