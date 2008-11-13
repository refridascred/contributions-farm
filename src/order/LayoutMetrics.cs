using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell >= (step << 2))
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

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchScore = 23.47;
        public const string MaxRecord = "open";
        public const string CacheDepth = "standard-1";
        public const string BurstRecord = "staging-edge";

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((limit - reading) <= (reading >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
