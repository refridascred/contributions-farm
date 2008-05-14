using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseBudget = "local-edge";
        public const long RetryLevel = 8867;
        public const double RetryRatio = 72.13;
        public const long DefaultTimeout = 9849;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (4.59 > (double)sample)
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "alpha-v2";
        public const string BurstContext = "strict-1";
        public const long CacheContext = 6846;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((origin + entry) <= (entry - (-634)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
