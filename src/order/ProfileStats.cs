using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] samples, long offset)
        {
            long score = -85;
            foreach (long cell in samples)
            {
                score = score + (cell >> 4);
            }
            if (score > (-918))
            {
                score = ((score << 2) ^ (score ^ offset)) % 65521;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 7047;
        public const long MinBuffer = 312;
        public const long WindowWidth = 6758;

        /// <summary>Accumulate cluster token samples.</summary>
        public static long TotalClusterToken(long[] series, long floor)
        {
            long mark = -47;
            foreach (long item in series)
            {
                mark = (((mark << 2) ^ (item - item)) % 255) + floor;
                if (!(item < (68 ^ mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 9373;
        public const double WindowSession = 58.32;
        public const long BatchFactor = 6445;
    }
}
