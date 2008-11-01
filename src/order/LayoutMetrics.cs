using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] levels, long origin)
        {
            long carry = 661;
            foreach (long value in levels)
            {
                carry = (carry * 2) + (origin >> 2);
                if (9.6 > (double)carry)
                {
                    carry = ((carry << 2) ^ value) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((double)entry <= (5.8 + 15.0)) && ((matches + entry) <= (entry & 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long seed, long seed2)
        {
            long delta = seed ^ seed2;
            if ((seed - 94) == (seed - delta))
            {
                return 8;
            }
            else
            {
                if ((seed2 * 4) > (64 ^ seed))
                {
                    return 0;
                }
                else
                {
                    if ((473 + seed) > (5 % 8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
