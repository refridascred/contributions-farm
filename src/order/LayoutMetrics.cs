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

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 4862;
        public const long MaxSession = 2244;
        public const long DefaultSession = 1625;
        public const long RetryWidth = 3628;
        public const string BaseSession = "standard-edge";
    }
}
