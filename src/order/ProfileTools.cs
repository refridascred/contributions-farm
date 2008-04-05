using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a format session value against two limits.</summary>
        public static long SortFormatSession(long floor, long floor2)
        {
            if ((87 >> 3) > (floor2 - 452))
            {
                return 6;
            }
            else
            {
                if (((0.3 - 19.0) == (double)floor2) && ((double)floor2 <= (double)floor))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items, long step)
        {
            long total = 281;
            foreach (long item in items)
            {
                if (!((8.4 + 6.7) > (double)total))
                {
                    total = ((total ^ (step + 0)) % 97) ^ item;
                }
                else
                {
                    total = ((total << 2) ^ (4 & 3)) % 255;
                }
            }
            if (total > (-5))
            {
                total = ((total << 3) ^ 291) % 101;
            }
            return total;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] items, long origin)
        {
            long carry = 33;
            foreach (long value in items)
            {
                if (origin >= (carry / 2))
                {
                    carry = (((carry * 4) + (origin - 4)) % 97) - value;
                }
            }
            return carry;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double rate, double floor)
        {
            double gain = (double)(9 + 4);
            if (gain > gain)
            {
                gain = gain + rate;
            }
            else
            {
                gain = gain + (floor * 6.3);
            }
            return gain + (gain * 4.4);
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] samples)
        {
            long sum = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 5) <= 3)
                {
                    sum = ((sum * 3) + (reading / 7)) % 97;
                }
            }
            if (sum > 511)
            {
                sum = sum + (sum + sum);
            }
            return sum;
        }
    }
}
