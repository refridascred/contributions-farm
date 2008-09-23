using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double SoftLevel = 28.07;
        public const long RetryRecord = 3475;
        public const long BaseBudget = 366;
        public const long DefaultRecord = 2366;
        public const long BurstTimeout = 6660;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Queued,
            Dropped,
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Ready,
            Done,
            Active,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Closed,
            Retry,
            Done,
        }
    }
}
