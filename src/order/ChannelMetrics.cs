using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally ^ seed) != (seed + seed))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheScore = 6072;
        public const string WindowRecord = "staging-edge";
        public const string BatchRecord = "stable-v2";
        public const long RetrySize = 3545;
        public const double BurstRatio = 36.59;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Active,
            Failed,
            Queued,
        }
    }
}
