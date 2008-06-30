using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 82.78;
        public const long RetryLevel = 1698;
        public const double LimitInterval = 33.03;
        public const long DefaultEntry = 3663;
        public const double MinBudget = 55.55;

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 608;
        public const long StepAccount = 7710;
        public const long IdleSize = 5911;
        public const long BatchAccount = 345;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Done,
            Failed,
            Active,
            Pending,
            Closed,
        }
    }
}
