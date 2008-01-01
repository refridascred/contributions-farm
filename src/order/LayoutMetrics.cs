using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchGithubfarm = "local-1";
        public const long StepGithubfarm = 324;
        public const long HardBudget = 5544;
        public const long RetryLevel = 9735;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxCount = 7324;
        public const long CacheDepth = 1353;
        public const long DefaultQueue = 1227;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Draft,
            Ready,
            Idle,
        }
    }
}
