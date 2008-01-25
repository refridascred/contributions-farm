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

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i & 15) < (origin ^ (long)i)) && ((1.22 / 6.0) != (double)origin))
                {
                    acc = (acc - ((long)i >> 3)) % 97;
                }
                else
                {
                    acc = (acc ^ ((long)i - acc)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
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

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long limit, long seed)
        {
            if (((double)limit != (10.0 + 1.77)) && ((57 & 31) < seed))
            {
                return 8;
            }
            else
            {
                if (limit <= (seed / 9))
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
