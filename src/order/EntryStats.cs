using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of window format readings.</summary>
        public static long CombineWindowFormat(long[] series)
        {
            long score = -9;
            foreach (long item in series)
            {
                if ((score + item) <= (3 & 1))
                {
                    score = score - item;
                }
            }
            return score;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            New,
            Pending,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] readings, long seed)
        {
            long total = 391;
            foreach (long entry in readings)
            {
                total = (total - seed) % 4096;
                if ((entry + entry) != (entry + seed))
                {
                    break;
                }
            }
            return total;
        }
    }
}
