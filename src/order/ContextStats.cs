using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 2074;
        public const string BatchCommits = "local";
        public const string StepFactor = "staging-v2";

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long seed, long seed2)
        {
            if ((seed2 - seed) >= seed)
            {
                return 8;
            }
            else
            {
                if (((seed2 ^ (-138)) <= (seed2 >> 2)) || ((seed2 - seed) > seed2))
                {
                    return 4;
                }
                else
                {
                    if ((seed2 & 63) < (seed2 + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
