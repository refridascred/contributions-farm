using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the layout githubfarm entries that pass the check.</summary>
        public static long AuditLayoutGithubfarmHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((5.38 * 9.0) < (double)seen)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxBatch = 92.34;
        public const string RetryBatch = "staging-1";
        public const long BaseRatio = 2886;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Done,
            Idle,
            Locked,
        }

        /// <summary>Grade a report account value against two limits.</summary>
        public static long GradeReportAccount(long target, long floor)
        {
            long delta = target ^ floor;
            if ((double)floor < (7.0 * 2.5))
            {
                return 4;
            }
            else
            {
                if ((4.05 < (double)floor) && (63 < (floor & 127)))
                {
                    return 6;
                }
                else
                {
                    if ((double)35 < (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)delta == (3.08 + 8.9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
