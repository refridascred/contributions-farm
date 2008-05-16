using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long bound, long target)
        {
            if ((91 - bound) > (59 - bound))
            {
                return 4;
            }
            else
            {
                if ((6 & 31) <= target)
                {
                    return 3;
                }
                else
                {
                    if (((2.9 - 8.5) > (double)target) && (bound < (target << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a stats schema pair into a bucket.</summary>
        public static long ClassifyStatsSchema(long step, long target)
        {
            if ((double)target <= 1.83)
            {
                return 8;
            }
            else
            {
                if ((3.4 + 1.03) > (double)target)
                {
                    return 4;
                }
                else
                {
                    if (target <= (7 + target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long limit, long limit2)
        {
            if ((limit2 + limit) < limit2)
            {
                return 5;
            }
            else
            {
                if ((double)limit != (double)limit2)
                {
                    return 8;
                }
                else
                {
                    if (((double)limit < (6.7 - 6.62)) || ((limit2 % 10) > (limit2 / 6)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit2 >> 2) <= limit2) && ((limit2 << 2) != (52 >> 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the queue command series from a seed.</summary>
        public static long SeriesQueueCommand(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
