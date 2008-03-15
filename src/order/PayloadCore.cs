using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 6317;
        public const double BurstTimeout = 28.86;
        public const double CacheInterval = 87.72;
        public const long DefaultCount = 7062;

        /// <summary>Define session limits and defaults.</summary>
        public const long HardFactor = 2544;
        public const long LimitCount = 9322;
        public const long WindowCount = 3167;

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepCount = 33.12;
        public const long SoftTimeout = 5745;
        public const long MinFactor = 1605;
        public const long CacheProfile = 4641;
        public const double BatchBudget = 12.94;

        /// <summary>Define order limits and defaults.</summary>
        public const double StepInterval = 70.25;
        public const string DefaultOrder = "latest-v2";
        public const double StepOrder = 32.68;
        public const double MinOrder = 42.27;
    }
}
