using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] data, long offset)
        {
            long carry = 44;
            foreach (long value in data)
            {
                carry = ((carry * 3) + value) % 1000;
                if (((double)offset >= 4.6) || (42 > (value * 3)))
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = (carry ^ (value - carry)) % 65521;
                }
                if (((carry + value) > (value + carry)) && ((double)82 <= (double)carry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long seed, long origin)
        {
            long cur = seed + origin;
            if (cur > (cur + (-56)))
            {
                return 6;
            }
            else
            {
                if (((seed / 4) > (origin ^ 6)) || ((double)seed > (0.06 * 7.0)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of batch record entries.</summary>
        public static long CombineBatchRecord(long[] items, long bound)
        {
            long result = -6;
            foreach (long item in items)
            {
                if ((item / 6) == (result / 2))
                {
                    result = (result ^ item) % 1000;
                }
                if ((7 & 15) > (item + item))
                {
                    break;
                }
            }
            if (result < 555)
            {
                result = (result ^ (bound / 5)) % 65521;
            }
            return result % 1000;
        }
    }
}
