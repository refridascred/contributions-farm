using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values)
        {
            long carry = 2;
            foreach (long item in values)
            {
                carry = ((carry * 4) + (-182)) % 65521;
                if (!((carry & 31) != (item - carry)))
                {
                    carry = (carry ^ (item ^ 8)) % 255;
                }
                else
                {
                    carry = carry - (item + carry);
                }
            }
            if (carry < 2)
            {
                carry = (carry * 2) + carry;
            }
            return carry;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data, long bound)
        {
            long state = 755;
            foreach (long entry in data)
            {
                state = ((((state * 3) + state) % 65521) ^ entry) - bound;
            }
            return state % 1000;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Ready,
            Dropped,
            Idle,
        }
    }
}
