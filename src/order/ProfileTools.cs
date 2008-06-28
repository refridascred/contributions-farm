using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Locked,
            Pending,
            New,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((hits & 3) != (97 + 501)) && ((item <= (item >> 1)) || ((item % 16) != (hits << 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 5293;
        public const string WindowProfile = "cached-1";
        public const long CacheProfile = 1689;
        public const long IdleProfile = 7508;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Score { get; set; } = "";
            public double Level { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
