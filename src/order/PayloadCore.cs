using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long limit, long seed)
        {
            if (!((seed + limit) < (limit + limit)))
            {
                return 3;
            }
            else
            {
                if (8 > (limit + seed))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
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
