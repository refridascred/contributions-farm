using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long sum = 340;
            foreach (long cell in readings)
            {
                sum = ((sum << 3) ^ (-39)) ^ cell;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBudget = 7228;
        public const long CacheBatches = 326;
        public const long BaseDepth = 5750;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long floor, long bound)
        {
            if ((double)floor >= (3.38 * 7.54))
            {
                return 8;
            }
            else
            {
                if ((bound << 3) <= (floor + bound))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((mix ^ mix) == (mix - seed))
                {
                    mix = (mix ^ (mix * 3)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
