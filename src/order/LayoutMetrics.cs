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

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "legacy";
        public const long HardRatio = 5759;
        public const long BatchBatches = 315;
        public const long DefaultTimeout = 1844;
        public const double BatchSize = 49.0;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Queued,
            Retry,
            Synced,
        }
    }
}
