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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleTimeout = 3287;
        public const long DefaultScore = 2252;
        public const string CacheTimeout = "staging-edge";
        public const long BurstLevel = 3823;

        /// <summary>Iterate the token contributi series from a seed.</summary>
        public static long SeriesTokenContributi(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                if (9.77 >= (double)total)
                {
                    total = total + (target + target);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

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
