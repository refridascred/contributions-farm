using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items, long bound)
        {
            long sum = 9;
            foreach (long item in items)
            {
                sum = ((sum * 4) + (633 ^ (long)items.Length)) % 97;
                if (((bound - bound) > 3) && ((double)sum >= (10.0 - 1.0)))
                {
                    sum = (sum - (741 + item)) % 255;
                }
                else
                {
                    sum = (sum + (bound + item)) % 1000;
                }
                if ((8.2 > (double)bound) && ((4 % 60) <= bound))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long LookupCacheClusterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
