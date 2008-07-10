using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of format token readings.</summary>
        public static long CompareFormatTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels)
        {
            long state = 83;
            foreach (long cell in levels)
            {
                if (!((long)levels.Length <= state))
                {
                    state = ((state - (963 & 31)) % 65521) ^ cell;
                }
            }
            return state;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Stale,
            Done,
            Synced,
            Closed,
        }

        /// <summary>Rank filter session input into a small class.</summary>
        public static long SortFilterSession(long bound, long bound2)
        {
            if (!((15.0 * 6.5) == (double)bound))
            {
                return 5;
            }
            else
            {
                if ((bound2 * 3) >= bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound2 >> 3) <= (bound & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound2 & 63) < bound) && ((3.0 * 7.0) < (2.0 * 1.1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long seed, long bound)
        {
            if ((10 * 4) < (seed - seed))
            {
                return 0;
            }
            else
            {
                if (14 >= seed)
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) > (seed + 68))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((71 << 1) < (bound + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
