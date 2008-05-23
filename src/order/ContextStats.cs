using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the metric already entries that pass the check.</summary>
        public static long AuditMetricAlreadyGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((667 << 3) < (cell + limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit format contributi readings against a rule.</summary>
        public static long CountFormatContributiOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count >= (bound + 344)) || ((-7) > bound))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            New,
            Failed,
            Active,
            Idle,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long target, long offset)
        {
            if ((target % 8) <= offset)
            {
                return 3;
            }
            else
            {
                if (target >= 3)
                {
                    return 4;
                }
                else
                {
                    if ((offset - 72) <= (target + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset <= 14.0) || (9.6 <= (double)target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
