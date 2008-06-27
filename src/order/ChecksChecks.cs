using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long target, long origin)
        {
            if ((4.41 - 5.91) != (double)origin)
            {
                return 0;
            }
            else
            {
                if (target <= (target / 5))
                {
                    return 1;
                }
                else
                {
                    if ((16 + origin) > (target - 45))
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

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] readings)
        {
            long result = 453;
            foreach (long entry in readings)
            {
                if ((4.8 + 5.09) > (double)entry)
                {
                    result = ((result * 3) + (entry ^ result)) % 101;
                }
            }
            return result % 65521;
        }
    }
}
