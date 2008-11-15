using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Idle,
            Dropped,
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
