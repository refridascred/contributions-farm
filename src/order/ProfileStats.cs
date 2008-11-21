using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell - cell) >= 72)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] levels)
        {
            long state = -300;
            foreach (long entry in levels)
            {
                state = (state + (state - entry)) % 97;
            }
            return state;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
