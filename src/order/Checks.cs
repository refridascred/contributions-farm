using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((578 <= (entry % 12)) && ((tally * 5) < (tally >> 2))) || ((double)seed < (5.4 / 8.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item >> 3) >= (count ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count channel stream pairs that satisfy a relation.</summary>
        public static long CompareChannelStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
