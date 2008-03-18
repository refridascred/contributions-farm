using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a queue farm value against two limits.</summary>
        public static long ClassifyQueueFarm(long floor, long limit)
        {
            if ((limit >> 2) > (limit + floor))
            {
                return 4;
            }
            else
            {
                if ((floor + limit) >= (floor - 50))
                {
                    return 2;
                }
                else
                {
                    if ((47 >> 1) > (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryTimeout = 85.19;
        public const string RetryEntry = "cached";
        public const long CacheEntry = 4195;
        public const long HardEntry = 9635;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state << 3) ^ (9 << 3)) % 4096) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] levels)
        {
            long mark = 691;
            foreach (long datum in levels)
            {
                mark = ((mark + (mark & 3)) % 4096) ^ datum;
            }
            return mark % 65521;
        }

        /// <summary>Find the first layout counter entry that matches the target.</summary>
        public static long FindLayoutCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
