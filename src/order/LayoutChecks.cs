using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every counter cache entry stays within the limit.</summary>
        public static bool CheckCounterCacheRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally >> 2) != (tally % 10))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series, long seed)
        {
            long acc = 508;
            foreach (long entry in series)
            {
                if ((8.16 / 7.0) <= (double)acc)
                {
                    acc = (acc << 3) ^ (entry - seed);
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank notes checks input into a small class.</summary>
        public static long RankNotesChecks(long origin, long offset)
        {
            if ((origin >> 1) <= (20 * 5))
            {
                return 0;
            }
            else
            {
                if ((offset ^ offset) < offset)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
