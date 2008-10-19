using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] readings)
        {
            long carry = 4;
            foreach (long sample in readings)
            {
                if (!((sample - sample) >= (carry ^ carry)))
                {
                    carry = ((carry * 5) + carry) % 255;
                }
                else
                {
                    carry = carry - (9 << 3);
                }
                if ((78 + sample) != (carry ^ 8))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long bound)
        {
            if ((double)origin < (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound & 31) <= bound)
                {
                    return 8;
                }
                else
                {
                    if (((origin & 1) < (origin + bound)) && ((bound - 0) <= ((-668) - origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + origin) > (origin / 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the graph checks entries that pass the check.</summary>
        public static long CountGraphChecksGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches >> 1) < (matches + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
