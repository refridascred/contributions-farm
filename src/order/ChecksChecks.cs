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

        /// <summary>Classify a entry already pair into a bucket.</summary>
        public static long BucketEntryAlready(long step, long seed)
        {
            if (seed >= (step + step))
            {
                return 1;
            }
            else
            {
                if (step < (step ^ seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed & 3) > (seed ^ 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 2452;
        public const string StepBudget = "standard-1";
        public const string StepWidth = "alpha";
        public const long IdleCount = 8999;
        public const long BurstWindow = 6612;
    }
}
