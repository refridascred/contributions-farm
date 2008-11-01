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

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels, long limit)
        {
            long acc = 82;
            foreach (long cell in levels)
            {
                if (acc <= (cell ^ 675))
                {
                    acc = (acc + acc) % 255;
                }
                else
                {
                    acc = (acc ^ (cell ^ 68)) % 101;
                }
                if ((1.2 + 2.0) < (double)limit)
                {
                    break;
                }
            }
            return acc;
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
