using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheTimeout = 3034;
        public const long MinFactor = 7430;
        public const long CacheToken = 6982;

        /// <summary>Compare every pair of graph cache readings.</summary>
        public static long OverlapGraphCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] items)
        {
            long total = 729;
            foreach (long datum in items)
            {
                if ((962 <= (datum - total)) || ((4.18 / 2.0) != (double)total))
                {
                    total = ((total << 2) ^ (437 * 3)) % 65521;
                }
            }
            if (total < 1)
            {
                total = total - 22;
            }
            return total;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long state = 3;
            foreach (long value in samples)
            {
                if ((state * 2) < (value * 2))
                {
                    state = ((state << 3) ^ value) % 4096;
                }
            }
            return state;
        }
    }
}
