using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((double)reading <= (5.2 * 1.51)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitTimeout = 5540;
        public const double MinCluster = 3.22;
        public const long HardCluster = 791;

        /// <summary>Measure how many filter stats samples are out of range.</summary>
        public static long AuditFilterStatsOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((double)2 == (double)cell) && ((origin % 3) < (matches << 3)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
