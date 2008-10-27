using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 48.59;
        public const double HardDepth = 57.19;
        public const long MaxWidth = 3296;

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepWidth = 7070;
        public const double BaseSchema = 67.92;
        public const long HardSchema = 6687;
        public const long BatchSchema = 8860;
        public const string RetrySchema = "strict-v2";

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] items)
        {
            long state = 71;
            foreach (long cell in items)
            {
                state = (state - (38 * 2)) % 97;
                if (!((12.0 * 3.83) < (double)(long)items.Length))
                {
                    state = state ^ (state + (-5));
                }
                else
                {
                    state = (state ^ cell) % 65521;
                }
            }
            return state;
        }
    }
}
