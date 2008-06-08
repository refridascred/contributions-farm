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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] values, long floor)
        {
            long acc = 25;
            foreach (long item in values)
            {
                if (109 < (floor & 7))
                {
                    acc = ((acc << 2) ^ (3 + floor)) ^ item;
                }
            }
            if (acc < 820)
            {
                acc = (acc - (floor & 63)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
