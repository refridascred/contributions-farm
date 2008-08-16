using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items, long floor)
        {
            long mark = 7;
            foreach (long datum in items)
            {
                if ((double)datum > (0.04 + 2.85))
                {
                    mark = mark ^ (datum * 3);
                    mark = mark - (floor - floor);
                }
                if ((893 >= (floor / 2)) || ((datum - 64) == (mark - (-87))))
                {
                    mark = ((mark << 2) ^ (floor * 5)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardScore = 3739;
        public const double DefaultDepth = 93.92;
        public const long BaseBudget = 5818;
        public const string BaseContext = "open-edge";

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 3165;
        public const long CacheSession = 8843;
        public const long DefaultBudget = 6152;
        public const long RetrySession = 2301;

        /// <summary>Fold a list of commits route readings.</summary>
        public static long DigestCommitsRoute(long[] data, long offset)
        {
            long carry = 52;
            foreach (long value in data)
            {
                carry = (((carry << 2) ^ value) % 97) + offset;
            }
            return carry;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
