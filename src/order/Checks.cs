using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long bound, long offset)
        {
            if (offset > (bound - offset))
            {
                return 6;
            }
            else
            {
                if ((double)bound > 9.88)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((782 + floor) <= (90 & 255))
                {
                    sum = (sum + (13 << 2)) % 101;
                }
                else
                {
                    sum = ((sum << 3) ^ (floor << 3)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
