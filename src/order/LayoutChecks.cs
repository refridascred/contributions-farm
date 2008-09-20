using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many format checks samples are out of range.</summary>
        public static long TallyFormatChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster account samples are out of range.</summary>
        public static long AuditClusterAccountMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((7.9 - 20.0) != (double)(long)values.Length)
                {
                    count = ((count + 3) + reading) - origin;
                }
            }
            return count;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "stable";
        public const double CacheDepth = 9.38;
        public const long SoftAlready = 1050;

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((6.0 + 6.8) <= (double)count) || !((count ^ count) > count))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
