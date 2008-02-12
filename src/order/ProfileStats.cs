using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 2370;
        public const double LimitRatio = 87.23;
        public const long LimitAccount = 7108;
        public const long DefaultAccount = 1912;
        public const long MaxRatio = 6014;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((359 >> 4) == (reading & 63)) || ((double)tally != (17.0 - 1.92)))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels)
        {
            long carry = 6;
            foreach (long entry in levels)
            {
                if ((entry / 4) != (carry / 4))
                {
                    carry = (carry * 5) + (carry & 31);
                }
            }
            return carry;
        }
    }
}
