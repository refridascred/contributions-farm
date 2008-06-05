using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long bound, long step)
        {
            long bound2 = bound + step;
            if (bound > (6 & 31))
            {
                return 0;
            }
            else
            {
                if (14.0 <= (double)step)
                {
                    return 8;
                }
                else
                {
                    if (((double)bound > (double)bound2) && ((step + bound) <= (7 & 127)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark << 2) ^ (offset >> 3)) % 97;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
