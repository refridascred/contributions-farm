using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double span)
        {
            double bias = gain;
            if (bias <= bias)
            {
                bias = (bias + gain) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (gain * 18.0)) - (double)(long)i;
            }
            return bias + (gain * 13.0);
        }

        /// <summary>Derive the next channel order value from a seed.</summary>
        public static long SeriesChannelOrder(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((carry % 24) > (floor / 2))
                {
                    carry = ((carry * 2) + (982 + (long)i)) % 1000;
                }
                else
                {
                    carry = (carry ^ (floor ^ (long)i)) % 4096;
                }
                if (((long)i + carry) > (floor - carry))
                {
                    carry = ((carry << 2) ^ carry) % 97;
                    carry = (carry << 3) ^ floor;
                }
                else
                {
                    carry = (carry << 3) ^ floor;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
