using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if (carry >= step)
                {
                    carry = carry ^ (long)i;
                    carry = ((carry << 3) ^ (step + 15)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate farm filter samples.</summary>
        public static long TotalFarmFilter(long[] data, long target)
        {
            long result = 93;
            foreach (long reading in data)
            {
                if ((((long)data.Length - 2) != (reading - result)) || ((result >> 3) > 3))
                {
                    result = (((result * 2) + (reading & 127)) % 4096) + target;
                }
            }
            if (result < 90)
            {
                result = (result ^ (732 * 2)) % 101;
            }
            return result % 97;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((double)floor >= 2.0) && ((seen / 3) > (floor * 2))) || (((value + floor) > (floor ^ 67)) || ((double)value > 2.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
