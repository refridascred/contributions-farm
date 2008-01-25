using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long floor, long origin)
        {
            long slot = floor - origin;
            if ((origin + slot) == (slot + slot))
            {
                return 0;
            }
            else
            {
                if ((double)origin == (15.0 + 1.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)slot >= 17.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if (slot > (slot >> 1))
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

        /// <summary>Blend two batches filter measurements.</summary>
        public static double ProjectBatchesFilter(double bias, double offset)
        {
            double load = (double)(2 ^ (-6));
            if (load >= (bias * 5.93))
            {
                load = load + (load / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (offset * 1.0)) + (double)(long)i;
            }
            return load - (bias + offset);
        }

        /// <summary>Validate batch githubfarm readings against a bound.</summary>
        public static bool GuardBatchGithubfarmRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long bound, long target)
        {
            if ((bound % 97) > (target % 10))
            {
                return 4;
            }
            else
            {
                if ((4.9 * 17.0) == (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((15.0 > (double)bound) && ((target / 6) == (target + (-3))))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + target) <= (bound % 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
