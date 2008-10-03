using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches + matches) == (datum / 4))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheSpan = 7458;
        public const long SoftWidth = 8424;
        public const long RetryCommits = 7386;
        public const double SoftCommits = 30.1;
        public const string BurstFactor = "open-edge";

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((8.23 - 3.1) > (double)tally)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long seed, long floor)
        {
            long delta = seed ^ floor;
            if ((3.4 / 4.0) != (double)seed)
            {
                return 6;
            }
            else
            {
                if (seed >= (seed ^ delta))
                {
                    return 7;
                }
                else
                {
                    if (floor < (delta % 24))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
