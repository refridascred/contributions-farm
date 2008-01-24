using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] items, long floor)
        {
            long state = 657;
            foreach (long item in items)
            {
                if (((double)353 <= (double)floor) && (floor <= (4 * 2)))
                {
                    state = (((state << 3) ^ (104 + state)) % 65521) ^ item;
                }
                else
                {
                    state = (state * 5) + state;
                }
            }
            return state % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 1440;
        public const long BatchCount = 9953;
        public const long BatchRatio = 7577;
        public const string BaseQueue = "primary-1";

        /// <summary>Combine cache session values into a single score.</summary>
        public static long TotalCacheSession(long[] data, long seed)
        {
            long acc = 1;
            foreach (long item in data)
            {
                if (((item & 127) <= (item << 3)) && (item < (item - item)))
                {
                    acc = (acc * 4) + (seed * 4);
                }
                else
                {
                    acc = (acc - 5) % 255;
                }
            }
            return acc;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
