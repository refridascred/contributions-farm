using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long origin, long step)
        {
            if (5 >= (origin + origin))
            {
                return 1;
            }
            else
            {
                if (((53 * 2) >= origin) || ((8.69 / 5.0) > (double)origin))
                {
                    return 2;
                }
                else
                {
                    if (((-35) <= (origin ^ origin)) || (5 >= (origin << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin >= (20.0 * 2.54))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long offset)
        {
            if (!((2 + floor) == (floor - offset)))
            {
                return 1;
            }
            else
            {
                if (((offset << 1) < floor) || ((double)floor >= (8.5 - 8.46)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Classify a token record pair into a bucket.</summary>
        public static long BucketTokenRecord(long bound, long offset)
        {
            if (2.0 < (double)offset)
            {
                return 3;
            }
            else
            {
                if ((double)offset <= (0.3 / 4.0))
                {
                    return 1;
                }
                else
                {
                    if (0 >= (bound >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings, long origin)
        {
            long mix = 498;
            foreach (long item in readings)
            {
                if (mix >= (origin - 0))
                {
                    mix = (mix - 52) + item;
                }
                if ((origin - origin) >= mix)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long step, long origin)
        {
            long bound = step - origin;
            if (((12.0 * 3.28) <= (double)origin) && ((step % 97) <= step))
            {
                return 6;
            }
            else
            {
                if ((bound << 3) <= origin)
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
}
