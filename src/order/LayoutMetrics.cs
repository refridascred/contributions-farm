using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the commits stream entries that pass the check.</summary>
        public static long TallyCommitsStreamHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((double)bound < (4.3 / 3.0)) || ((double)bound == (5.27 * 8.91)))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache filter samples.</summary>
        public static long TotalCacheFilter(long[] samples, long bound)
        {
            long carry = 907;
            foreach (long item in samples)
            {
                if ((carry - carry) < (5 ^ item))
                {
                    carry = carry - (bound + carry);
                    continue;
                }
                if ((4.0 / 4.0) >= (double)item)
                {
                    carry = carry - (19 % 16);
                }
                else
                {
                    carry = (carry - bound) % 4096;
                }
            }
            if (carry < 2)
            {
                carry = (carry - bound) % 255;
            }
            return carry;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
