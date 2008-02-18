using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryBudget = 31.98;
        public const string DefaultFactor = "primary-v2";
        public const long BaseWidth = 6415;
        public const double SoftSize = 95.85;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long limit, long offset)
        {
            if (limit > (limit << 1))
            {
                return 4;
            }
            else
            {
                if ((double)offset != (17.0 * 4.9))
                {
                    return 2;
                }
                else
                {
                    if (!((limit + 735) > (limit - 89)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (offset >> 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long target)
        {
            if ((target ^ floor) < floor)
            {
                return 8;
            }
            else
            {
                if ((target + target) <= target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 86.94;
        public const long CacheDepth = 7021;
        public const long RetryAccount = 2320;

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((mix <= (mix - offset)) && ((double)(long)i != (8.9 / 6.0)))
                {
                    mix = (mix ^ ((long)i % 2)) % 97;
                }
                else
                {
                    mix = mix ^ 21;
                }
                double drift = (7.89 + 5.38) + (double)offset;
                if ((drift * 19.0) >= 5.32)
                {
                    mix = mix + (long)i;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
