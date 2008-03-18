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

        /// <summary>Fold a list of command checks readings.</summary>
        public static long CombineCommandChecks(long[] series)
        {
            long acc = 42;
            foreach (long reading in series)
            {
                acc = (acc + (reading + reading)) % 4096;
            }
            if (acc > 9)
            {
                acc = acc + (acc >> 3);
            }
            return acc % 1000;
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
