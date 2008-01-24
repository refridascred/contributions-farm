using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] series)
        {
            long carry = 3;
            foreach (long cell in series)
            {
                carry = ((carry ^ carry) % 97) ^ cell;
            }
            if (carry > 44)
            {
                carry = (carry ^ (carry + carry)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long CountToolsStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample >= (sample * 4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a queue contributi pair into a bucket.</summary>
        public static long SortQueueContributi(long offset, long floor)
        {
            if (((floor << 1) >= floor) || ((1.7 + 0.53) >= (double)1))
            {
                return 5;
            }
            else
            {
                if ((floor >> 5) == (offset / 4))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
