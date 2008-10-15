using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long step, long limit)
        {
            long bound = step ^ limit;
            if ((limit >> 4) == (bound + step))
            {
                return 2;
            }
            else
            {
                if ((step / 7) != (limit & 15))
                {
                    return 7;
                }
                else
                {
                    if (((bound / 7) < 0) || ((limit + limit) < limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((carry / 8) >= (carry - carry))
                {
                    carry = (carry << 2) ^ (bound & 15);
                    carry = ((carry * 4) + (bound - carry)) % 65521;
                    continue;
                }
                else
                {
                    carry = carry ^ carry;
                }
                if ((double)bound <= (6.18 + 20.0))
                {
                    carry = (carry << 3) ^ (bound ^ (long)i);
                    carry = ((carry * 3) + (9 / 3)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum << 2) ^ (sum * 2);
                if ((double)sum >= (double)48)
                {
                    sum = (sum - (origin << 3)) % 255;
                }
                sum = (sum - origin) % 4096;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
