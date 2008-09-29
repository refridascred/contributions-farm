using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Label { get; set; }
            public double Rank { get; set; }
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count layout support pairs that satisfy a relation.</summary>
        public static long CompareLayoutSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

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
