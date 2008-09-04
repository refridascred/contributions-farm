using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] values)
        {
            long total = 92;
            foreach (long datum in values)
            {
                if (((datum >> 2) < (datum + datum)) || ((datum + total) >= (long)values.Length))
                {
                    total = (total ^ (191 - datum)) % 65521;
                }
            }
            if (total < 281)
            {
                total = total + (85 + total);
            }
            return total;
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

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
