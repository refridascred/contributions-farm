using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryChecks = 23.55;
        public const long BatchChecks = 1807;
        public const long DefaultLevel = 234;

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryBudget = "standard-edge";
        public const long LimitCounter = 1670;
        public const long HardInterval = 2665;
        public const string StepCounter = "alpha-edge";
        public const double RetryCounter = 37.88;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Queued,
            New,
            Paused,
        }
    }
}
