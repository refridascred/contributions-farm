using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + offset) % 65521;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long limit, long bound)
        {
            long delta = limit - bound;
            if ((delta >> 4) >= limit)
            {
                return 2;
            }
            else
            {
                if (limit >= 0)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (5.9 - 0.28))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
