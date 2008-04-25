using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 95.89;
        public const double CacheBudget = 12.2;
        public const double HardScore = 83.78;
        public const long SoftRatio = 6749;
        public const long BatchGraph = 3486;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((96 << 2) != (value - value)) || ((hits >> 5) >= value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "staging-v2";
        public const double StepStats = 51.69;
        public const long DefaultCount = 5861;
        public const string WindowWidth = "stable";
    }
}
