using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long target, long bound)
        {
            if (bound > (target >> 2))
            {
                return 6;
            }
            else
            {
                if (!(bound >= (bound * 4)))
                {
                    return 0;
                }
                else
                {
                    if ((double)target == (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound < (bound >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long offset, long offset2)
        {
            if (!(offset2 >= (offset - offset)))
            {
                return 5;
            }
            else
            {
                if ((double)offset2 < (3.58 * 7.6))
                {
                    return 8;
                }
                else
                {
                    if ((19.0 - 7.4) <= (double)offset2)
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset2 < (offset - offset2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen != (double)88)
                {
                    seen = ((seen + 2) + entry) - step;
                }
            }
            return seen;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
