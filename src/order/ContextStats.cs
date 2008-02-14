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

        /// <summary>Combine schema layout values into a single score.</summary>
        public static long CombineSchemaLayout(long[] samples, long origin)
        {
            long sum = -9;
            foreach (long cell in samples)
            {
                sum = (((sum * 3) + (origin << 3)) % 65521) ^ cell;
                sum = ((sum * 5) + (origin & 255)) % 1000;
            }
            return sum;
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
