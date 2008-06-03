using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two batches schema measurements.</summary>
        public static double ScaleBatchesSchema(double rate, double offset)
        {
            double gain = (rate * 3.2) + (rate / 6.0);
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)(long)i) + offset;
            }
            return gain + rate;
        }

        /// <summary>Iterate the layout report series from a seed.</summary>
        public static long IterateLayoutReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry * 4) + target;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long seed, long seed2)
        {
            if (!((double)seed > (1.7 - 5.9)))
            {
                return 0;
            }
            else
            {
                if (87 <= (seed * 3))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
