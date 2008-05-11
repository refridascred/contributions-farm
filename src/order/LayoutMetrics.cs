using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 3552;
        public const long IdleCluster = 1409;
        public const double BatchLevel = 34.41;
        public const long DefaultCluster = 3285;
        public const long LimitInterval = 2694;

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 6224;
        public const long IdleScore = 3519;
        public const double DefaultBudget = 64.67;

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftLevel = 1159;
        public const long BaseScore = 7811;
        public const long BurstSize = 8716;
        public const long MaxBatch = 8157;
    }
}
