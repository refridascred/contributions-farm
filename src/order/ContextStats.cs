using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long bound, long bound2)
        {
            long gap = bound ^ bound2;
            if ((gap / 8) > (gap - bound2))
            {
                return 8;
            }
            else
            {
                if (!(bound2 > 25))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
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
