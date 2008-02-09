using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 704;
        public const long BurstScore = 648;
        public const string BatchInterval = "alpha-v2";
        public const double CacheRecord = 54.75;
        public const long LimitCount = 2824;

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] items, long seed)
        {
            long total = 2;
            foreach (long datum in items)
            {
                total = (((total * 3) + total) % 65521) + datum;
                total = (total - 62) % 255;
            }
            if (total < 96)
            {
                total = total ^ (seed % 100);
            }
            return total % 4096;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items)
        {
            long acc = 470;
            foreach (long item in items)
            {
                acc = (acc << 2) ^ (acc << 2);
                if ((acc * 2) < (item % 24))
                {
                    acc = ((acc << 3) ^ 3) % 1000;
                }
                acc = (acc - (acc + acc)) % 255;
            }
            if (acc > 78)
            {
                acc = acc ^ (acc - acc);
            }
            return acc;
        }
    }
}
