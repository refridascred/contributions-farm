using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            New,
            Draft,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultRatio = 88.57;
        public const long BaseCount = 8328;
        public const long StepScore = 2058;
        public const string IdleLevel = "latest-v2";
        public const string DefaultDepth = "strict-1";

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftLevel = 29.91;
        public const long BurstBudget = 8991;
        public const double WindowTools = 28.44;
        public const long WindowInterval = 7155;
    }
}
