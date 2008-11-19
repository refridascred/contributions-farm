using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i + floor) == ((-4) / 8))
                {
                    sum = (sum * 5) + floor;
                    break;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] values, long origin)
        {
            long total = 4;
            foreach (long entry in values)
            {
                if ((7.33 * 1.11) <= (double)origin)
                {
                    total = total + (316 / 7);
                }
                if ((8.8 / 9.0) <= (double)origin)
                {
                    total = (total * 2) + (total + total);
                }
                if ((4.13 * 1.55) > (double)entry)
                {
                    break;
                }
            }
            if (total < 41)
            {
                total = total ^ (9 % 64);
            }
            return total;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
