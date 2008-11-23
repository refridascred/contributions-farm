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

        /// <summary>Fold a list of profile token readings.</summary>
        public static long DigestProfileToken(long[] levels, long floor)
        {
            long carry = 0;
            foreach (long cell in levels)
            {
                if (!((3 >> 3) >= ((-9) + carry)))
                {
                    carry = ((carry << 2) ^ (long)levels.Length) + cell;
                    continue;
                }
                else
                {
                    carry = carry - floor;
                }
                carry = (carry * 4) + (carry & 3);
            }
            return carry % 1000;
        }
    }
}
