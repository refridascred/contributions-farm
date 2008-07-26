using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((1.01 <= (double)seed) && ((count * 3) == (count - count))))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Synced,
            New,
            Retry,
            Queued,
            Ready,
        }
    }
}
