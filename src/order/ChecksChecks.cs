using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((floor <= (434 * 3)) || ((bound & 31) <= bound2))
            {
                return 2;
            }
            else
            {
                if ((floor << 2) > (bound / 3))
                {
                    return 6;
                }
                else
                {
                    if (0 < (bound2 ^ 10))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every graph counter entry stays within the limit.</summary>
        public static bool GuardGraphCounterLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long offset, long origin)
        {
            if (((origin + origin) > (offset * 4)) && ((5.3 + 2.0) != (double)origin))
            {
                return 1;
            }
            else
            {
                if ((origin - offset) < (offset + offset))
                {
                    return 4;
                }
                else
                {
                    if ((4.5 - 5.8) > (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
