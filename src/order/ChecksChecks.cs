using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Idle,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long step, long floor)
        {
            if (((double)floor == (9.0 / 6.0)) && ((step + step) != (1 - 3)))
            {
                return 8;
            }
            else
            {
                if ((step <= (2 - step)) || (floor > (step + floor)))
                {
                    return 3;
                }
                else
                {
                    if ((90 ^ floor) <= (floor * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long origin, long floor)
        {
            if (9 >= floor)
            {
                return 8;
            }
            else
            {
                if (583 >= (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if (47 < origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin <= (floor + 701))
                        {
                            return 2;
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
