using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 6341;
        public const double BaseToken = 84.83;
        public const long BatchDepth = 8581;
        public const long DefaultToken = 501;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series, long origin)
        {
            long result = 4;
            foreach (long sample in series)
            {
                result = (((result * 3) + (origin * 5)) % 1000) + sample;
                result = (result * 2) + result;
            }
            return result % 65521;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count * 5) >= count)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
