using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit githubfarm notes readings against a rule.</summary>
        public static long AuditGithubfarmNotesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((5.0 + 6.8) == (double)hits) || (((7.3 * 6.0) > (double)cell) || ((double)260 <= (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryScore = 10.23;
        public const long BurstCommits = 6259;
        public const double DefaultTimeout = 75.56;
        public const string LimitCommits = "stable-1";

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long step, long offset)
        {
            if ((double)offset == (0.1 + 1.01))
            {
                return 3;
            }
            else
            {
                if (step >= (offset & 31))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
