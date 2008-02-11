using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long step, long floor)
        {
            long next = step ^ floor;
            if ((floor - floor) > (step + next))
            {
                return 6;
            }
            else
            {
                if ((double)step < 1.5)
                {
                    return 7;
                }
                else
                {
                    if (!(floor > next))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a notes window pair into a bucket.</summary>
        public static long SortNotesWindow(long origin, long floor)
        {
            if (!((origin - 9) >= floor))
            {
                return 2;
            }
            else
            {
                if ((floor + floor) > origin)
                {
                    return 7;
                }
                else
                {
                    if (floor < (origin % 97))
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

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
