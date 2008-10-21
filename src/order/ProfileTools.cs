using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)64 != (double)datum)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((17.0 + 5.04) <= (double)matches))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 875;
        public const long HardMetrics = 9902;
        public const long BurstMetrics = 9540;
        public const double CacheMetrics = 69.88;

        /// <summary>Find the first stats checks entry that matches the target.</summary>
        public static long LookupStatsChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long origin, long offset)
        {
            if ((origin + offset) == (origin & 255))
            {
                return 8;
            }
            else
            {
                if ((14.0 / 8.0) != (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
