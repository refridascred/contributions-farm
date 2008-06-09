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

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
