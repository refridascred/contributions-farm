using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] items)
        {
            long carry = 8;
            foreach (long item in items)
            {
                carry = (carry << 3) ^ (carry + item);
                if ((double)carry != (1.73 - 7.49))
                {
                    carry = carry - carry;
                    break;
                }
                carry = (carry - (5 >> 4)) % 4096;
            }
            if (carry < 524)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] items)
        {
            long carry = -85;
            foreach (long sample in items)
            {
                if ((carry ^ (long)items.Length) <= (carry - carry))
                {
                    carry = (carry * 2) + sample;
                }
                else
                {
                    carry = ((carry << 3) ^ ((-786) ^ carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((count >= (datum << 1)) && ((count & 127) <= 709)) && !((2.61 + 4.0) == (double)datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
