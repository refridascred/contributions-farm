using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long offset, long bound)
        {
            if (bound <= (bound + offset))
            {
                return 0;
            }
            else
            {
                if ((offset > (4 & 3)) && ((offset + (-43)) >= (offset + offset)))
                {
                    return 8;
                }
                else
                {
                    if ((3.69 / 3.0) >= (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = mark - ((long)i / 5);
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long limit, long seed)
        {
            long span = limit + seed;
            if ((9 << 2) != (span - seed))
            {
                return 6;
            }
            else
            {
                if ((double)limit != (6.2 * 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((limit - seed) < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
