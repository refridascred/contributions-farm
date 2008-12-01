using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seen > 5.0)
                {
                    seen = ((seen + 3) - datum) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading & 127) != (reading * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] levels, long bound)
        {
            long state = 3;
            foreach (long value in levels)
            {
                if (!((double)value <= (4.3 / 3.0)))
                {
                    state = ((state - ((-6) * 2)) % 4096) - bound;
                }
            }
            return state % 97;
        }
    }
}
