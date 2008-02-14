using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 2047;
        public const string IdleQueue = "strict-v2";
        public const long BurstQueue = 8214;
        public const double WindowFactor = 98.77;
        public const double BaseCount = 42.27;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinCluster = 9.6;
        public const long HardCluster = 9644;
        public const long DefaultCluster = 5625;
        public const long CacheCluster = 3555;
        public const long StepLevel = 2798;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] data, long seed)
        {
            long state = 56;
            foreach (long entry in data)
            {
                if ((entry >> 2) > (state * 5))
                {
                    state = ((state - (state ^ 4)) % 255) + seed;
                }
            }
            return state % 97;
        }
    }
}
