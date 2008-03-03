using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up schema batch samples.</summary>
        public static long CompareSchemaBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheBudget = 6044;
        public const long MaxContributi = 208;
        public const long CacheDepth = 2167;
        public const double WindowContributi = 68.87;
        public const double BaseContributi = 8.78;

        /// <summary>Rank cache stats input into a small class.</summary>
        public static long ClassifyCacheStats(long seed, long target)
        {
            long slot = seed + target;
            if (seed >= slot)
            {
                return 2;
            }
            else
            {
                if (target <= ((-742) % 97))
                {
                    return 8;
                }
                else
                {
                    if (!((seed + seed) <= (slot >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long origin, long offset)
        {
            long prev = origin + offset;
            if ((314 & 7) != (prev << 1))
            {
                return 7;
            }
            else
            {
                if ((prev + 3) < (prev * 3))
                {
                    return 5;
                }
                else
                {
                    if (!((14.0 + 18.0) <= (double)prev))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
