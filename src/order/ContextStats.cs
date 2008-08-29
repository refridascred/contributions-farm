using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long floor, long step)
        {
            if (step < floor)
            {
                return 6;
            }
            else
            {
                if ((step + step) >= floor)
                {
                    return 2;
                }
                else
                {
                    if (!((double)floor <= (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every channel editor entry stays within the limit.</summary>
        public static bool CheckChannelEditorLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!!((70 + hits) > hits))
                {
                    hits = (hits + 2) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i + origin) <= state)
                {
                    state = ((state << 3) ^ 430) % 101;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
