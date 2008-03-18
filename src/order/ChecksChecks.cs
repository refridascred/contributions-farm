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

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
