using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Ready,
            New,
            Retry,
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
