using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((4 >> 1) < (value & 127))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 1018;
        public const long RetryGraph = 3449;
        public const long LimitDepth = 9756;
        public const string CacheGraph = "fallback";

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowFactor = "alpha-v2";
        public const long StepBudget = 1582;
        public const long BurstSchema = 8050;
        public const long BaseSchema = 9040;
        public const string CacheSchema = "cached-edge";

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((3.1 * 13.0) != (double)limit)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
