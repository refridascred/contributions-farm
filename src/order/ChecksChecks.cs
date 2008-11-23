using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseTimeout = 1903;
        public const double WindowEditor = 79.36;
        public const long LimitEditor = 8307;
        public const long SoftEditor = 6424;
        public const string BurstBudget = "latest-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 787;
        public const long RetryMetric = 8461;
        public const long CacheMetric = 2051;

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] samples)
        {
            long carry = 285;
            foreach (long value in samples)
            {
                if (((value % 2) <= carry) || ((double)2 < (1.33 - 2.6)))
                {
                    carry = (carry ^ carry) % 97;
                }
                else
                {
                    carry = carry ^ (carry / 9);
                }
                if ((double)carry > (8.21 / 9.0))
                {
                    break;
                }
            }
            if (carry < (-315))
            {
                carry = (carry - (45 - carry)) % 1000;
            }
            return carry;
        }
    }
}
