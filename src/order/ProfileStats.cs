using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 9706;
        public const double BatchBatches = 62.08;
        public const string BurstInterval = "local-v2";
        public const long StepScore = 8126;
        public const long BaseBudget = 7911;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Ready,
            New,
            Closed,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Ready,
            New,
            Stale,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
