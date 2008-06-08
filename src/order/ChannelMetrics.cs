using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] data, long limit)
        {
            long sum = 950;
            foreach (long cell in data)
            {
                sum = sum ^ (6 + cell);
                if (((limit - sum) == (sum << 1)) && ((double)limit >= (8.71 + 11.0)))
                {
                    sum = (sum ^ (4 << 1)) % 97;
                }
                if (((cell + 23) != (0 + sum)) || ((4.08 * 2.4) < (double)sum))
                {
                    break;
                }
            }
            if (sum > 832)
            {
                sum = (sum ^ (792 + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (664 >= (item / 2))
                {
                    hits = (hits + 1) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
