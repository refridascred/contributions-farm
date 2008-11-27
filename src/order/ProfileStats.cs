using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark ^ (mark * 5)) % 97;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] levels)
        {
            long score = 7;
            foreach (long cell in levels)
            {
                if ((0.53 - 6.8) != (double)score)
                {
                    score = (((score * 2) + (64 * 5)) % 4096) + cell;
                }
            }
            return score;
        }
    }
}
