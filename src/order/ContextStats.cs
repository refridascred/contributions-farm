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

        /// <summary>Count the batch checks entries that pass the check.</summary>
        public static long TallyBatchChecksOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((8 - 675) > (count / 2))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
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
