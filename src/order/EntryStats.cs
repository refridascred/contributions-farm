using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long acc = 24;
            foreach (long cell in readings)
            {
                acc = ((acc * 2) + (acc + cell)) % 4096;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 8852;
        public const long LimitContext = 6189;
        public const string MinDepth = "stable";

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftBudget = 4627;
        public const long CacheChannel = 6702;
        public const double RetryChannel = 36.19;
        public const long IdleChannel = 5301;
        public const string SoftFactor = "strict-1";
    }
}
