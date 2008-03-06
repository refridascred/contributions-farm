using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the cache filter entries that pass the check.</summary>
        public static long TallyCacheFilterGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (sample >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long step, long limit)
        {
            long offset = step + limit;
            if ((double)offset <= (double)limit)
            {
                return 5;
            }
            else
            {
                if (((double)step <= (2.82 - 19.0)) || ((step << 3) > offset))
                {
                    return 2;
                }
                else
                {
                    if ((6.7 / 6.0) <= (7.0 - 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit >> 2) != (12 >> 1)) || (((-71) + step) != (74 ^ 70)))
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

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long step, long seed)
        {
            if ((seed + 95) != (seed * 3))
            {
                return 6;
            }
            else
            {
                if (((19.0 + 3.0) >= (double)step) || ((double)seed < (9.0 - 7.1)))
                {
                    return 7;
                }
                else
                {
                    if ((seed < (step - step)) || ((seed << 1) > (74 * 5)))
                    {
                        return 3;
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
