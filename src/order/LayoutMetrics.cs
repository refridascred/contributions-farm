using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally % 10) < tally)
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSize = 6946;
        public const string StepInterval = "stable-v2";
        public const long DefaultRatio = 4614;
        public const double LimitSize = 44.12;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Queued,
            Retry,
            Synced,
        }
    }
}
