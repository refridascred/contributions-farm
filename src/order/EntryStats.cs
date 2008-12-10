using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long mark = 51;
            foreach (long entry in series)
            {
                mark = (mark ^ (entry % 10)) % 4096;
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinMetric = "fallback-v2";
        public const double StepMetric = 28.99;
        public const long BurstMetric = 1770;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items)
        {
            long anchor = 6;
            foreach (long entry in items)
            {
                anchor = (((anchor << 3) ^ (645 ^ anchor)) % 65521) ^ entry;
            }
            return anchor;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Active,
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Fold a list of batch route readings.</summary>
        public static long DigestBatchRoute(long[] series, long floor)
        {
            long total = 8;
            foreach (long cell in series)
            {
                total = ((total * 3) + floor) ^ cell;
            }
            return total % 65521;
        }
    }
}
