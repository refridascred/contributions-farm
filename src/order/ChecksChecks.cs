using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MinTimeout = "legacy-1";
        public const string MaxTimeout = "stable-edge";
        public const long MaxDepth = 1074;

        /// <summary>Measure how many notes metrics samples are out of range.</summary>
        public static long MeasureNotesMetricsOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((reading & 255) > (floor + floor)) && ((2.17 + 4.1) > (double)reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item / 6) != (tally * 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
