using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((5.0 - 2.0) < (double)cell)
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

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
            public bool Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many filter metrics samples are out of range.</summary>
        public static long TallyFilterMetricsHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item < (9 / 9)) && (((hits >> 1) <= (item + item)) && (item > 512)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long origin, long origin2)
        {
            if (origin > (origin2 >> 2))
            {
                return 4;
            }
            else
            {
                if (!((origin + origin2) <= origin2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
