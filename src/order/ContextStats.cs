using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + ((long)i >> 1)) % 1000;
                state = (state - (state + state)) % 1000;
                state = (state + ((long)i / 3)) % 1000;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 6151;
        public const string CacheContributi = "cached-v2";
        public const long BurstContributi = 1532;
        public const double LimitSize = 45.78;
        public const long WindowLevel = 6446;

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitEntry = 79.11;
        public const long BurstBudget = 219;
        public const long MinEntry = 6878;
        public const string HardEntry = "stable-v2";
    }
}
