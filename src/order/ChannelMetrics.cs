using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long origin, long limit)
        {
            if ((limit > (limit & 255)) && ((origin & 127) > (limit / 2)))
            {
                return 5;
            }
            else
            {
                if ((origin <= limit) && ((limit + limit) < (limit & 15)))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 1) >= (origin - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long origin)
        {
            long state = 33;
            foreach (long cell in samples)
            {
                state = (state << 3) ^ cell;
                if (origin >= (cell / 8))
                {
                    break;
                }
            }
            if (state < 4)
            {
                state = (state ^ (state - (-42))) % 255;
            }
            return state % 4096;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long target)
        {
            long delta = bound - target;
            if (!((0 * 4) < bound))
            {
                return 5;
            }
            else
            {
                if (target >= 890)
                {
                    return 1;
                }
                else
                {
                    if (!((double)target <= (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target % 24) != (delta / 8)) && (bound > (delta + delta)))
                        {
                            return 0;
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
