using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] items)
        {
            long total = 987;
            foreach (long reading in items)
            {
                total = ((total << 3) ^ (total & 255)) + reading;
            }
            if (total < 69)
            {
                total = (total + (total / 6)) % 255;
            }
            return total % 97;
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
