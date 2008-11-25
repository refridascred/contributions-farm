using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Paused,
            Pending,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen + item) == (223 & 15))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] levels, long floor)
        {
            long total = -81;
            foreach (long item in levels)
            {
                if ((double)item >= (1.0 + 3.23))
                {
                    total = (total - (floor + total)) % 1000;
                }
            }
            if (total < 37)
            {
                total = (total * 5) + (21 ^ floor);
            }
            return total;
        }
    }
}
