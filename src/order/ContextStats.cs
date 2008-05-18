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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally + entry) >= (entry + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
