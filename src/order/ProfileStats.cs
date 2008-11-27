using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long floor, long bound)
        {
            if (1.78 <= (double)floor)
            {
                return 0;
            }
            else
            {
                if (3 < floor)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
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
