using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((bound + acc) > (bound - (-2)))
                {
                    acc = (acc ^ 735) % 1000;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of report stream entries.</summary>
        public static long DigestReportStream(long[] readings)
        {
            long mark = 812;
            foreach (long cell in readings)
            {
                if (((cell % 60) > 7) && ((mark + cell) >= cell))
                {
                    mark = (mark + mark) % 101;
                }
            }
            return mark;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long floor, long step)
        {
            if ((floor <= (floor + step)) || ((floor + 0) != (step + step)))
            {
                return 8;
            }
            else
            {
                if ((step ^ floor) > (796 + step))
                {
                    return 3;
                }
                else
                {
                    if (floor >= (step ^ floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next entry contributi value from a seed.</summary>
        public static long StepEntryContributi(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (((carry * 4) + carry) % 1000) ^ (long)i2;
                }
                carry = (carry - (offset - carry)) % 1000;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
