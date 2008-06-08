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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long target, long step)
        {
            if ((6.0 + 3.42) == (double)step)
            {
                return 2;
            }
            else
            {
                if (!((step * 3) > (target * 3)))
                {
                    return 3;
                }
                else
                {
                    if (!((target & 255) <= (step & 7)))
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
