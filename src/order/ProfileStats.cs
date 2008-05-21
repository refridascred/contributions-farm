using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                long edge = (long)i + (carry & 1);
                if (edge > (38 >> 1))
                {
                    edge = (edge << 3) ^ bound;
                    edge = edge + (8 - edge);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
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
