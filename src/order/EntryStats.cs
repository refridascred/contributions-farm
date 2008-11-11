using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 9765;
        public const long SoftGithubfarm = 6891;
        public const long LimitInterval = 98;
        public const long CacheTimeout = 2960;
        public const long CacheWidth = 5341;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((tally / 3) < 4) || (tally >= (item + item))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
