using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = total - (total >> 1);
                total = ((total * 3) + (origin % 100)) % 101;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((((cell + count) >= cell) && (count >= (179 >> 4))) || ((double)count > (3.8 * 8.09)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a profile already value against two limits.</summary>
        public static long SortProfileAlready(long target, long bound)
        {
            long prev = target - bound;
            if ((bound - 342) != (target >> 3))
            {
                return 2;
            }
            else
            {
                if ((624 - bound) < (354 / 2))
                {
                    return 5;
                }
                else
                {
                    if ((4 - bound) < (prev + 114))
                    {
                        return 8;
                    }
                    else
                    {
                        if (4.77 <= (double)prev)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
