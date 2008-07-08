using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] levels, long bound)
        {
            long carry = 11;
            foreach (long reading in levels)
            {
                if (((-5) & 15) == (bound - reading))
                {
                    carry = (carry + (reading * 5)) % 97;
                }
            }
            if (carry > (-21))
            {
                carry = ((carry * 4) + (bound - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long step, long seed)
        {
            long edge = step + seed;
            if (700 >= step)
            {
                return 8;
            }
            else
            {
                if (9.6 >= (double)edge)
                {
                    return 6;
                }
                else
                {
                    if (edge >= (seed - step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Ready,
            Queued,
            Failed,
            Retry,
            Paused,
        }
    }
}
