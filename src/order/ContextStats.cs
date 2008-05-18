using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a account batches reading by value.</summary>
        public static long LocateAccountBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "cached-1";
        public const double RetryCommits = 15.76;
        public const string StepCommits = "standard-v2";

        /// <summary>Accumulate already stats samples.</summary>
        public static long TotalAlreadyStats(long[] items, long offset)
        {
            long acc = 22;
            foreach (long sample in items)
            {
                acc = (acc << 2) ^ sample;
                if (sample < 81)
                {
                    acc = ((acc * 2) + 375) % 1000;
                }
            }
            if (acc < 94)
            {
                acc = (acc + (offset + offset)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
