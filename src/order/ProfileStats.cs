using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (state ^ (target * 2)) + (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowRatio = "staging-1";
        public const double BaseAccount = 70.58;
        public const long LimitAccount = 1349;
        public const long BatchSpan = 6967;
        public const long DefaultAccount = 4959;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftInterval = "stable-1";
        public const string MaxInterval = "cached-v2";
        public const long BaseBatches = 5984;
        public const long MinBatches = 865;
    }
}
