using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next support commits value.</summary>
        public static double AdjustSupportCommits(double ratio, double floor)
        {
            double mean = (ratio - floor) / 9.0;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean - 6.03)) - (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Score { get; set; }
            public double Count { get; set; }
        }

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
