using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a channel checks value against two limits.</summary>
        public static long GradeChannelChecks(long origin, long seed)
        {
            if ((6.96 / 7.0) == (double)seed)
            {
                return 8;
            }
            else
            {
                if ((double)seed > 5.7)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            Done,
            Stale,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long limit)
        {
            if ((origin - limit) != (6 - limit))
            {
                return 5;
            }
            else
            {
                if ((limit + 16) <= (limit & 255))
                {
                    return 6;
                }
                else
                {
                    if (((origin / 7) < (origin << 3)) && ((726 + limit) < origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (960 <= (limit % 10))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
