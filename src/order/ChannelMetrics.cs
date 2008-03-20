using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
