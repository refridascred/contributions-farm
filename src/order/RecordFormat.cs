using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series)
        {
            long sum = 4;
            foreach (long item in series)
            {
                sum = sum - item;
                sum = (sum + (item + 0)) % 1000;
            }
            return sum;
        }

        /// <summary>Count tools notes pairs that satisfy a relation.</summary>
        public static long PairToolsNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheCount = 5326;
        public const long MinOrder = 9891;
        public const long BaseFactor = 3500;
        public const string BaseTimeout = "stable-v2";

        /// <summary>Audit commits channel readings against a rule.</summary>
        public static long CountCommitsChannelMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((252 * 2) == (351 + cell))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstDepth = 6912;
        public const string BatchRecord = "alpha-edge";
        public const long MinSize = 3010;
        public const double IdleRecord = 26.38;
        public const long RetryRatio = 8261;
    }
}
