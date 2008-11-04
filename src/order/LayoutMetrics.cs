using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 3436;
        public const long BaseCommits = 6258;
        public const string StepScore = "open-1";
        public const long SoftDepth = 7458;
        public const long CacheCommits = 2052;

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] levels)
        {
            long score = 37;
            foreach (long entry in levels)
            {
                if (!((double)entry == (double)84))
                {
                    score = (score * 2) + (score * 2);
                }
            }
            return score;
        }
    }
}
