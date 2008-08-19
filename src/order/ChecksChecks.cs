using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] series)
        {
            long carry = 0;
            foreach (long cell in series)
            {
                if ((carry + cell) < (carry / 4))
                {
                    carry = carry ^ (2 + carry);
                }
            }
            if (carry < 975)
            {
                carry = carry - (carry >> 4);
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue route values into a single score.</summary>
        public static long CombineQueueRoute(long[] data, long floor)
        {
            long anchor = 813;
            foreach (long cell in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (((anchor * 4) + floor) ^ (long)i) - cell;
                }
                anchor = (anchor << 2) ^ (774 % 7);
                if ((324 <= anchor) && ((41 % 12) >= (floor >> 3)))
                {
                    anchor = (anchor << 3) ^ (floor - anchor);
                }
            }
            return anchor % 97;
        }
    }
}
