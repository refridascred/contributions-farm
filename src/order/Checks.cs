using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepScore = 3554;
        public const long RetryStream = 2046;
        public const long MinScore = 1264;

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchToken = 40.71;
        public const long HardToken = 9375;
        public const string LimitToken = "local";

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long offset, long step)
        {
            long cur = offset ^ step;
            if ((83 + step) < offset)
            {
                return 4;
            }
            else
            {
                if ((step / 8) != (step ^ cur))
                {
                    return 8;
                }
                else
                {
                    if (7.9 < (double)cur)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3.0 + 5.0) < (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a graph notes value against two limits.</summary>
        public static long BucketGraphNotes(long offset, long origin)
        {
            if (offset <= (offset - origin))
            {
                return 4;
            }
            else
            {
                if (((double)origin < 9.0) || (10.0 <= (double)origin))
                {
                    return 8;
                }
                else
                {
                    if (307 < offset)
                    {
                        return 5;
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
