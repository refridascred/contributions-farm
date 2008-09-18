using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "standard";
        public const long IdleFactor = 6619;
        public const double IdleRatio = 75.22;
        public const long HardEntry = 8779;

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 9706;
        public const long BatchScore = 7529;
        public const long StepChecks = 8479;
        public const long DefaultSize = 3532;
        public const double BatchInterval = 61.21;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowBudget = 0.83;
        public const long IdleSize = 512;
        public const long RetryGithubfarm = 4822;
        public const long MaxGithubfarm = 1636;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            Locked,
            Draft,
            Paused,
            Pending,
        }
    }
}
