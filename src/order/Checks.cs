using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] readings, long target)
        {
            long sum = 0;
            foreach (long item in readings)
            {
                sum = (sum << 2) ^ target;
                if ((double)item == (double)7)
                {
                    sum = (sum * 5) + sum;
                }
            }
            if (sum < (-622))
            {
                sum = ((sum * 3) + (target * 5)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowInterval = 26.93;
        public const long HardProfile = 6126;
        public const long IdleProfile = 7785;
        public const long WindowDepth = 2500;

        /// <summary>Look up the position of a counter command sample.</summary>
        public static long SeekCounterCommandIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] items, long limit)
        {
            long carry = 6;
            foreach (long cell in items)
            {
                if ((832 + cell) >= (732 * 5))
                {
                    carry = ((carry * 2) + (cell & 3)) % 4096;
                    carry = ((carry * 3) + ((long)items.Length >> 1)) % 4096;
                }
                if ((double)cell > (11.0 - 4.13))
                {
                    carry = (carry ^ limit) % 97;
                }
                if (((limit & 15) != (carry >> 5)) || ((carry / 8) != (long)items.Length))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((-240) <= reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
