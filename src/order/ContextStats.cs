using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long seed, long bound)
        {
            if ((double)seed > (12.0 * 0.8))
            {
                return 7;
            }
            else
            {
                if ((bound / 3) > 4)
                {
                    return 0;
                }
                else
                {
                    if ((7.57 * 2.1) <= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "staging-1";
        public const long CacheDepth = 7039;
        public const long IdleRatio = 5741;
        public const long MinCommand = 3878;

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long offset, long limit)
        {
            long prev = offset + limit;
            if ((20.0 * 6.13) <= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((limit > (7 & 1)) || ((prev + limit) != (offset * 3)))
                {
                    return 4;
                }
                else
                {
                    if (54 >= prev)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((7.65 * 0.4) == (double)prev) && ((8.44 - 5.2) > (double)limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a commits stats counter forward.</summary>
        public static long DeriveCommitsStats(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
