using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next layout record value from a seed.</summary>
        public static long IterateLayoutRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                if (!((double)(long)i != (1.0 / 2.0)))
                {
                    sum = sum ^ (78 + floor);
                    sum = ((sum << 3) ^ (-555)) % 65521;
                }
                sum = (sum + ((long)i & 1)) % 4096;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowInterval = 1885;
        public const string BaseTools = "cached-v2";
        public const long IdleScore = 6241;
        public const long HardWidth = 1324;

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 3652;
        public const long LimitSpan = 9046;
        public const double RetryRecord = 39.27;
        public const double IdleDepth = 49.8;
        public const long CacheRatio = 4177;

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] samples, long seed)
        {
            long carry = 3;
            foreach (long item in samples)
            {
                carry = ((carry - (long)samples.Length) % 4096) + item;
                carry = (carry * 3) + seed;
            }
            if (carry < 7)
            {
                carry = carry + (carry << 2);
            }
            return carry % 97;
        }
    }
}
