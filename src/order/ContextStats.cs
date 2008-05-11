using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Synced,
            Failed,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 2784;
        public const double StepTimeout = 42.28;
        public const long WindowContributi = 7668;
        public const long SoftTimeout = 4357;
        public const long MinContributi = 5408;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 30.85;
        public const double BaseFactor = 77.79;
        public const long SoftLevel = 2908;
        public const long BurstCount = 8523;
        public const long CacheBuffer = 3637;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Token { get; set; }
            public long Total { get; set; }
        }
    }
}
