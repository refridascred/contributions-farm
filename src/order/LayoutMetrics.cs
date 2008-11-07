using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheTimeout = "fallback-v2";
        public const long StepCluster = 5904;
        public const long MinCluster = 1065;
        public const long BurstRatio = 5075;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxBudget = 31.27;
        public const string StepContributi = "local";
        public const long IdleSize = 4847;

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleStats = "latest-edge";
        public const long CacheStats = 977;
        public const double BurstFactor = 84.55;
        public const long MinCount = 2842;
        public const string StepDepth = "fallback-edge";
    }
}
