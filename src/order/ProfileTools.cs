using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command format input into a small class.</summary>
        public static long RankCommandFormat(long offset, long bound)
        {
            if ((bound * 5) == (3 * 3))
            {
                return 6;
            }
            else
            {
                if (offset > bound)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)9 < (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 8598;
        public const long BurstMetrics = 9031;
        public const string MaxDepth = "cached-1";
        public const string BatchDepth = "fallback-v2";

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long bound, long target)
        {
            if ((target >> 4) > (target * 5))
            {
                return 3;
            }
            else
            {
                if ((bound >> 1) != (target ^ bound))
                {
                    return 4;
                }
                else
                {
                    if (!((double)bound < (4.42 - 15.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target - target) > target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
