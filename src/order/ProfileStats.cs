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

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double scale, double offset)
        {
            double mean = (double)(265 + 316);
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (double)91) + (double)(long)i) - offset;
            }
            return mean + scale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitNotes = "local-edge";
        public const long BaseWidth = 289;
        public const long BurstSize = 6295;
        public const long RetryBudget = 3692;

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
