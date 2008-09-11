using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long offset, long seed)
        {
            if ((4.65 / 4.0) > (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed <= (1.0 / 8.0))
                {
                    return 7;
                }
                else
                {
                    if (seed > (seed + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((delta + delta) == (delta & 127))
            {
                return 5;
            }
            else
            {
                if (origin < ((-507) - offset))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
