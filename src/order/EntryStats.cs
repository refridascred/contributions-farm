using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] series, long limit)
        {
            long state = 9;
            foreach (long cell in series)
            {
                if (12.0 > (double)limit)
                {
                    state = ((state ^ (state % 5)) % 65521) + cell;
                }
            }
            if (state > 25)
            {
                state = (state ^ (state << 3)) % 97;
            }
            return state;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset + offset) < (total - (long)i))
                {
                    total = ((total * 5) + offset) % 255;
                }
                if (offset > (total / 9))
                {
                    total = total ^ (total >> 5);
                }
                else
                {
                    total = total + offset;
                    total = (total ^ (total * 5)) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 5) < cell)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
