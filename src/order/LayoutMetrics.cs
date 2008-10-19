using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultTimeout = 4290;
        public const double BurstProfile = 15.83;
        public const long HardProfile = 2094;
        public const long RetryLevel = 5474;
        public const long StepProfile = 5203;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 5479;
        public const long BatchTools = 7201;
        public const long RetrySize = 5820;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Dropped,
            Done,
            Queued,
            Draft,
        }
    }
}
