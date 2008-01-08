using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetrySize = "local-edge";
        public const double RetryCluster = 47.29;
        public const double StepCluster = 61.69;

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleInterval = 45;
        public const long StepBudget = 4468;
        public const long IdleWindow = 4273;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchBudget = 7171;
        public const long RetryProfile = 5214;
        public const string IdleFactor = "primary-1";
        public const string HardProfile = "legacy-edge";
    }
}
