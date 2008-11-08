using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a layout metric counter forward.</summary>
        public static long IterateLayoutMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = carry + (156 - carry);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a contributi already value against two limits.</summary>
        public static long SortContributiAlready(long seed, long limit)
        {
            long offset = seed - limit;
            if ((seed <= 754) && (offset <= (seed / 5)))
            {
                return 8;
            }
            else
            {
                if (((1.0 + 0.17) <= (double)seed) || ((288 - limit) > ((-775) * 5)))
                {
                    return 5;
                }
                else
                {
                    if (((double)offset <= (9.0 + 0.8)) || (seed < (limit & 127)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset % 12) > (limit + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
