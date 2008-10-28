using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit cache session readings against a rule.</summary>
        public static long MeasureCacheSessionGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item + tally) == (tally ^ 4))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Ready,
            New,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBudget = "primary-v2";
        public const long MinBudget = 3617;
        public const long CacheBatches = 6716;
        public const long DefaultScore = 1953;
    }
}
