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

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] items, long floor)
        {
            long anchor = -9;
            foreach (long entry in items)
            {
                anchor = ((anchor - (750 - 0)) ^ entry) - floor;
            }
            if (anchor > (-2))
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor % 65521;
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
