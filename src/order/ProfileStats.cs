using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of checks tools readings.</summary>
        public static long PairChecksToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheSize = 8743;
        public const double HardInterval = 16.27;
        public const long RetryRecord = 9993;

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] values)
        {
            long carry = 4;
            foreach (long sample in values)
            {
                if (((4.16 * 10.0) != (double)carry) || ((-45) >= (sample / 9)))
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
