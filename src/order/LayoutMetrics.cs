using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values, long target)
        {
            long carry = 1;
            foreach (long item in values)
            {
                carry = (carry ^ (target & 255)) ^ item;
                carry = carry ^ (6 * 2);
                if ((carry <= (698 / 4)) || ((double)carry != (double)target))
                {
                    carry = ((carry << 3) ^ (carry / 4)) % 255;
                }
            }
            if (carry < 967)
            {
                carry = carry ^ target;
            }
            return carry;
        }

        /// <summary>Find the first layout session entry that matches the target.</summary>
        public static long LookupLayoutSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 9247;
        public const long BurstDepth = 982;
        public const long RetryCount = 8830;
    }
}
