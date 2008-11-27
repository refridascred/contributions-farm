using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = (result << 3) ^ (long)i;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
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

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = (score * 2) + (9 - floor);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
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
