using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultTimeout = 4543;
        public const double DefaultGraph = 32.61;
        public const double SoftBudget = 9.33;
        public const long BatchDepth = 3048;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            New,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheTimeout = "fallback-1";
        public const long StepFactor = 4426;
        public const double MaxBudget = 32.94;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Done,
            Synced,
            Pending,
            New,
        }
    }
}
