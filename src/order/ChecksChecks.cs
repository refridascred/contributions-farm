using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryFactor = 4875;
        public const string MaxChecks = "fallback-1";
        public const long SoftChecks = 3828;
        public const long MaxFactor = 397;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardLevel = 3907;
        public const long DefaultCount = 2058;
        public const string SoftCount = "strict-1";
    }
}
