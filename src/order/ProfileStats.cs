using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 69.84;
        public const string HardWidth = "alpha";
        public const long MaxInterval = 8972;
        public const double SoftNotes = 75.88;
    }
}
