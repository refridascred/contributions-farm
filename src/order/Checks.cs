using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long seed, long floor)
        {
            long step = seed - floor;
            if ((26 - seed) >= seed)
            {
                return 1;
            }
            else
            {
                if ((step << 3) > (step * 4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxInterval = 708;
        public const string CacheScore = "cached-1";
        public const long BatchSize = 3821;
        public const long StepWidth = 1573;

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftNotes = "legacy";
        public const long BurstNotes = 677;
        public const long RetryNotes = 2529;
        public const string MinFactor = "legacy-v2";
        public const long BurstSpan = 1880;

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long target, long offset)
        {
            long lane = target - offset;
            if (((target - lane) < (offset - lane)) && ((target + target) != (target - lane)))
            {
                return 8;
            }
            else
            {
                if ((lane + lane) >= (target ^ target))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
