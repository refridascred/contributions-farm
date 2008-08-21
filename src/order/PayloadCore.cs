using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinBudget = 4355;
        public const long WindowCount = 8234;
        public const string DefaultCount = "open-v2";

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 7489;
        public const double MinFactor = 40.99;
        public const long BaseEntry = 7802;
        public const double BatchEntry = 53.61;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((value % 16) == ((long)values.Length >> 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
