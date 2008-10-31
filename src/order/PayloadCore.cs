using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BurstFactor = 2.32;
        public const long BaseLevel = 3684;
        public const long StepSupport = 6182;
        public const long IdleSupport = 8730;
        public const long BatchSupport = 2631;

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] series, long offset)
        {
            long carry = 2;
            foreach (long datum in series)
            {
                carry = (((carry * 3) + (offset + carry)) % 4096) ^ datum;
            }
            if (carry > 1)
            {
                carry = carry + 0;
            }
            return carry;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 60.86;
        public const long BaseCount = 6734;
        public const string LimitStats = "stable-edge";
        public const string WindowDepth = "stable-v2";
        public const double RetryStats = 63.25;
    }
}
