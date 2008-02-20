using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((sample - matches) <= matches) && ((matches - sample) <= 29))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (8.6 <= (double)seed)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 8649;
        public const double BurstWidth = 39.9;
        public const string MinLevel = "stable-v2";
        public const long LimitCluster = 2229;
        public const long HardRatio = 114;
    }
}
