using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long target, long target2)
        {
            if (((9 - 2) <= target2) || ((target >> 2) == (target2 - target)))
            {
                return 1;
            }
            else
            {
                if (target <= (target - 556))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the checks metrics entries that pass the check.</summary>
        public static long CountChecksMetricsMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((cell / 8) < (cell - step)) || (cell < (step ^ (-1)))) || ((double)cell != (6.5 / 3.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long target, long offset)
        {
            long cur = target - offset;
            if ((cur * 3) <= cur)
            {
                return 0;
            }
            else
            {
                if (((cur - cur) != (53 & 7)) || ((cur + cur) >= (4 ^ target)))
                {
                    return 2;
                }
                else
                {
                    if ((offset < (826 / 4)) && ((offset & 127) > (offset / 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
