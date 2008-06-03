using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Idle,
            Failed,
            Closed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 94.39;
        public const double BurstLevel = 95.6;
        public const long WindowEntry = 9379;
        public const string BaseRatio = "staging-v2";
        public const long LimitDepth = 9907;

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 1.49;
        public const long HardSchema = 7672;
        public const double DefaultBudget = 71.67;
        public const string WindowSchema = "local-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 989;
        public const long IdleFarm = 6314;
        public const long DefaultWidth = 951;
        public const long CacheInterval = 4832;
        public const string MaxBudget = "staging-1";
    }
}
