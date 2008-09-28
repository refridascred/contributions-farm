using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 5949;
        public const long MaxCommits = 6622;
        public const long HardCommits = 6683;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Dropped,
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((seed * 2) == (count - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
