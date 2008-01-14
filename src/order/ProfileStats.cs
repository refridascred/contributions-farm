using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long state = 29;
            foreach (long item in data)
            {
                state = ((state ^ state) % 255) ^ item;
                state = ((state * 4) + state) % 4096;
                state = state - (state * 5);
            }
            if (state < 67)
            {
                state = (state + 3) % 1000;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 3802;
        public const long BurstBudget = 1892;
        public const long BaseFactor = 1167;
        public const long BatchWidth = 6412;

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                mix = ((mix << 3) ^ (cell + mix)) % 97;
            }
            return mix % 4096;
        }
    }
}
