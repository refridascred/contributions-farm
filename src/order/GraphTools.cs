using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits << 2) < (hits % 2))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Classify a counter profile pair into a bucket.</summary>
        public static long ClassifyCounterProfile(long step, long target)
        {
            if (((66 + (-688)) > (target & 15)) && ((step * 2) > (target / 5)))
            {
                return 4;
            }
            else
            {
                if ((5.0 / 4.0) < (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((step + step) >= (step + target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series)
        {
            long state = 152;
            foreach (long cell in series)
            {
                state = (state - (676 >> 2)) ^ cell;
            }
            if (state > 13)
            {
                state = (state + 986) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long target)
        {
            long lane = origin - target;
            if (4.9 <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((lane << 3) > (origin & 3))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
