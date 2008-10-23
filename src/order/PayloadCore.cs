using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((floor >> 2) < floor)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheFactor = "local-v2";
        public const long BatchGraph = 2658;
        public const string MaxSpan = "staging";

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 9057;
        public const double RetryBudget = 44.08;
        public const long LimitCounter = 8424;
        public const string IdleCounter = "alpha-edge";

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepLevel = 6406;
        public const long LimitEditor = 7128;
        public const long HardEditor = 8452;
        public const string DefaultSpan = "stable-1";
        public const string DefaultEditor = "fallback-v2";
    }
}
