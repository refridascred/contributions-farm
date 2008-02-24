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

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((item >= (offset + item)) && ((double)tally < 6.04)) || ((double)item <= (7.0 + 8.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
