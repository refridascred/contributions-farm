using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double HardLevel = 35.75;
        public const long RetrySpan = 5019;
        public const double RetryCache = 21.03;

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
