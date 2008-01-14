using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
