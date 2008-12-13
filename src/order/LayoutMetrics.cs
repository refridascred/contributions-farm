using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Queued,
            New,
            Ready,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 702;
        public const double RetryCount = 92.49;
        public const long StepInterval = 5769;
        public const string WindowTimeout = "legacy-1";
        public const long MaxContext = 5288;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((((count << 3) <= reading) || (((long)series.Length + count) != (4 << 3))) || ((count - count) < (reading + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
