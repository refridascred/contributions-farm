using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit account editor readings against a rule.</summary>
        public static long MeasureAccountEditorOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((4.0 < (double)cell) || ((cell / 5) >= (cell ^ 402))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((0.4 + 5.9) <= (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a batches tools value against two limits.</summary>
        public static long BucketBatchesTools(long step, long target)
        {
            long prev = step - target;
            if (((9.5 - 3.8) != (double)prev) || ((target / 6) == (prev >> 2)))
            {
                return 5;
            }
            else
            {
                if (step >= target)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
