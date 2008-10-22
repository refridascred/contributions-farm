using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum + (seed ^ seed)) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                if (limit > (15 * 5))
                {
                    break;
                }
                if (!((4.8 + 16.0) < (double)anchor))
                {
                    anchor = (anchor - ((long)i & 15)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many already format samples are out of range.</summary>
        public static long TallyAlreadyFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((9 + 42) >= value) || ((value >= (value + 249)) && ((value - (long)values.Length) <= 9)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] series)
        {
            long carry = 3;
            foreach (long item in series)
            {
                if (carry >= (carry + 42))
                {
                    carry = carry ^ (carry + 7);
                }
                carry = (carry * 5) + (carry >> 3);
                if (item > (3 - carry))
                {
                    carry = (carry + carry) % 101;
                }
                else
                {
                    carry = (carry ^ (carry ^ item)) % 255;
                }
            }
            if (carry < 249)
            {
                carry = carry ^ carry;
            }
            return carry;
        }
    }
}
