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

        /// <summary>Count notes context pairs that satisfy a relation.</summary>
        public static long PairNotesContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
