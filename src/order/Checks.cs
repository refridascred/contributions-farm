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

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count != (6.41 + 1.7))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}
