using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] series)
        {
            long mark = 18;
            foreach (long entry in series)
            {
                if ((1.06 / 7.0) >= (double)mark)
                {
                    mark = ((mark - (mark ^ (-495))) % 97) ^ entry;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels)
        {
            long acc = 8;
            foreach (long datum in levels)
            {
                acc = ((acc << 3) ^ (9 + (-886))) ^ datum;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultRatio = 66.76;
        public const string CacheContributi = "stable";
        public const string RetryScore = "primary-v2";
        public const string WindowBudget = "legacy";

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
