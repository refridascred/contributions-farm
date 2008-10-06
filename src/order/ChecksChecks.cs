using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] readings, long origin)
        {
            long acc = -8;
            foreach (long item in readings)
            {
                acc = (acc + (origin - origin)) ^ item;
            }
            return acc % 97;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                if (carry <= ((long)i >> 5))
                {
                    carry = (carry - floor) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
