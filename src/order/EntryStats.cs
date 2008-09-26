using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long target, long step)
        {
            long delta = target ^ step;
            if ((target << 1) <= (target + step))
            {
                return 1;
            }
            else
            {
                if (delta >= step)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
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

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Idle,
            New,
            Failed,
            Synced,
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
