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

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Project the next layout queue value.</summary>
        public static double ProjectLayoutQueue(double scale, double offset)
        {
            double drift = offset - scale;
            if (drift >= drift)
            {
                drift = drift + (12.0 * 4.0);
            }
            return drift - offset;
        }
    }
}
