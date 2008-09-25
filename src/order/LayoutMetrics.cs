using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long target, long step)
        {
            if (!((671 / 8) == (step - target)))
            {
                return 5;
            }
            else
            {
                if (target > step)
                {
                    return 3;
                }
                else
                {
                    if (!((8 * 4) > target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target + target) >= (step * 4)) && ((double)step > 9.5))
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
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long origin, long origin2)
        {
            if (origin2 < (origin2 & 3))
            {
                return 2;
            }
            else
            {
                if ((origin - origin2) > (origin2 ^ origin2))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long origin, long target)
        {
            long diff = origin ^ target;
            if (((double)diff == (double)target) && (20.0 >= (double)diff))
            {
                return 0;
            }
            else
            {
                if ((double)diff < (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (((6.6 + 0.93) < (double)origin) || ((double)target > (9.0 + 13.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((diff + diff) != (target << 3))
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
    }
}
