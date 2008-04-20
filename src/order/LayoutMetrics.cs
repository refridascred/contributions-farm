using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long target, long origin)
        {
            long bound = target - origin;
            if (origin >= (bound & 255))
            {
                return 2;
            }
            else
            {
                if ((double)target > (double)origin)
                {
                    return 8;
                }
                else
                {
                    if ((bound << 1) > (target + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target + origin) <= (480 % 100))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long seed)
        {
            if ((double)offset <= (1.0 - 7.0))
            {
                return 4;
            }
            else
            {
                if (((4.6 * 13.0) >= (double)offset) || ((seed + seed) < (offset << 2)))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= 8.77)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
