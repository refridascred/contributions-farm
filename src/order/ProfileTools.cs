using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Owner { get; set; }
            public bool Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Synced,
            Stale,
            New,
            Locked,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] values, long origin)
        {
            long result = 54;
            foreach (long reading in values)
            {
                result = ((result - origin) % 4096) + reading;
            }
            return result % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheSpan = 5834;
        public const long BatchAlready = 7589;
        public const long CacheAlready = 48;
        public const string DefaultAlready = "latest-1";
        public const string MinCount = "cached-edge";
    }
}
