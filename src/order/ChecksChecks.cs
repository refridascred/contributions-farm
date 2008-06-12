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

        /// <summary>Classify a batch route pair into a bucket.</summary>
        public static long BucketBatchRoute(long floor, long origin)
        {
            long slot = floor + origin;
            if (origin <= slot)
            {
                return 5;
            }
            else
            {
                if (!((slot % 24) <= origin))
                {
                    return 8;
                }
                else
                {
                    if (11.0 > (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((slot + floor) == (floor & 255)) || ((floor << 3) > (floor / 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
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
