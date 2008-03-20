using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] items, long seed)
        {
            long mix = 5;
            foreach (long cell in items)
            {
                mix = ((mix - (914 & 3)) % 65521) + seed;
                if (!((double)17 < (double)mix))
                {
                    mix = mix + (cell ^ cell);
                }
            }
            return mix;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long origin, long bound)
        {
            if ((origin ^ origin) < (origin + bound))
            {
                return 5;
            }
            else
            {
                if (origin < (origin + 313))
                {
                    return 6;
                }
                else
                {
                    if (!((origin - origin) == (6 % 16)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + bound) <= origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
