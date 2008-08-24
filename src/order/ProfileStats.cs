using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] readings, long seed)
        {
            long total = 6;
            foreach (long item in readings)
            {
                total = ((total - item) % 1000) - seed;
                total = ((total * 4) + item) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 30;
        public const long BatchWidth = 5236;
        public const long CacheRatio = 5414;
        public const long BaseScore = 3010;
        public const long RetryTimeout = 5615;

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] data, long seed)
        {
            long state = 430;
            foreach (long item in data)
            {
                if (item >= (13 & 31))
                {
                    state = (state * 2) + (seed + item);
                }
            }
            if (state > 34)
            {
                state = (state ^ (1 & 3)) % 97;
            }
            return state;
        }
    }
}
