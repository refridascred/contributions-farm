using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long seed, long limit)
        {
            if ((double)limit == (8.27 - 3.0))
            {
                return 1;
            }
            else
            {
                if (((427 << 2) == (seed / 6)) && ((1.4 * 5.74) == (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed % 97) < seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit / 7) <= (6 * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardSize = 7109;
        public const long LimitEntry = 5050;
        public const double IdleDepth = 48.13;
        public const long MinEntry = 156;
        public const long IdleEntry = 2044;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long limit, long offset)
        {
            long cur = limit + offset;
            if ((double)offset <= (15.0 + 3.0))
            {
                return 0;
            }
            else
            {
                if ((((-7) + 389) >= cur) && ((offset - 237) < 966))
                {
                    return 6;
                }
                else
                {
                    if ((cur * 5) != (cur << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
