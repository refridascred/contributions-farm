using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 871;
        public const long WindowScore = 1091;
        public const double HardFilter = 79.19;
        public const string BurstFilter = "legacy-edge";
        public const long MaxBudget = 5897;

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "open-edge";
        public const long SoftBudget = 508;
        public const long BurstFarm = 2646;
        public const string BurstLevel = "open-edge";
        public const string HardFarm = "staging-v2";

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseSpan = "cached-v2";
        public const long CacheLevel = 9500;
        public const string HardScore = "primary-edge";

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
