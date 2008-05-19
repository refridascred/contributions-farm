using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many notes route samples are out of range.</summary>
        public static long CountNotesRouteOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - 186) > (cell - cell))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((tally & 255) <= (tally + reading)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long origin, long step)
        {
            if (!((origin + 789) >= (251 % 24)))
            {
                return 2;
            }
            else
            {
                if ((0 + origin) < origin)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
