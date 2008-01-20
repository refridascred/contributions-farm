using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!(((long)values.Length - cell) > (hits / 6)) && ((38 - hits) >= (cell * 3)))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Audit profile stream readings against a rule.</summary>
        public static long TallyProfileStreamGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((42 >= (44 - cell)) && ((double)matches > (17.0 / 9.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 7755;
        public const long CacheLevel = 4748;
        public const string RetryDepth = "fallback-1";
        public const long DefaultAlready = 3166;
        public const long StepSize = 355;

        /// <summary>Validate tools session readings against a bound.</summary>
        public static bool CheckToolsSessionLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
