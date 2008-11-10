using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long target, long limit)
        {
            long step = target + limit;
            if ((limit % 5) > ((-71) % 2))
            {
                return 1;
            }
            else
            {
                if ((step > (limit >> 3)) && ((target % 7) >= (target / 3)))
                {
                    return 3;
                }
                else
                {
                    if (!((target >> 2) == (step + limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long bound, long origin)
        {
            long diff = bound + origin;
            if (((double)origin > (7.4 - 7.9)) && ((348 - diff) <= diff))
            {
                return 0;
            }
            else
            {
                if (5.0 > (double)diff)
                {
                    return 1;
                }
                else
                {
                    if ((8.6 * 0.23) != (double)origin)
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

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
