using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the report farm series from a seed.</summary>
        public static long StepReportFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 11; i++)
            {
                result = (result - ((-87) % 7)) % 101;
                if (!((result / 9) < (587 - result)))
                {
                    result = ((result * 4) + (floor - floor)) % 101;
                }
                if ((result >= (long)i) || ((0.5 + 5.4) < (double)floor))
                {
                    result = ((result << 3) ^ (floor << 3)) % 97;
                    result = ((result * 2) + ((long)i >> 3)) % 1000;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
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
