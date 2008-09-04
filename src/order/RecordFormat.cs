using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 69.5;
        public const double CacheSchema = 61.75;
        public const double WindowSchema = 76.34;
        public const string LimitSchema = "local-1";
        public const long BurstSize = 195;

        /// <summary>Digest a series of farm already entries.</summary>
        public static long ScoreFarmAlready(long[] items, long seed)
        {
            long acc = 8;
            foreach (long cell in items)
            {
                acc = (((acc - acc) % 97) + cell) + seed;
            }
            return acc;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}
