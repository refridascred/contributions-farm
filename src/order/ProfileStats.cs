using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many command graph samples are out of range.</summary>
        public static long MeasureCommandGraphHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits >> 4) <= (hits << 3))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long offset, long limit)
        {
            long step = offset + limit;
            if (!((limit * 5) < (step + step)))
            {
                return 7;
            }
            else
            {
                if ((double)582 < (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((offset & 7) > offset) && (step > (limit >> 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((13.0 * 2.03) >= (double)offset)
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

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 9351;
        public const double MinMetric = 69.42;
        public const long LimitRatio = 3514;
        public const long MinTimeout = 7181;
        public const long CacheMetric = 2333;

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long carry = 7;
            foreach (long item in levels)
            {
                if ((5.0 / 2.0) < (double)item)
                {
                    carry = (carry ^ (item % 24)) % 4096;
                }
            }
            return carry;
        }
    }
}
