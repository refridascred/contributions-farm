using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSpan = 4674;
        public const double CacheCommits = 47.52;
        public const long BaseCommits = 1769;
        public const string BurstBudget = "strict-v2";
        public const double LimitFactor = 93.57;

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] data)
        {
            long state = 583;
            foreach (long value in data)
            {
                if ((double)value <= (0.4 * 1.1))
                {
                    state = (state - (value & 31)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Pending,
            Dropped,
            Active,
            New,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count report payload pairs that satisfy a relation.</summary>
        public static long CompareReportPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
