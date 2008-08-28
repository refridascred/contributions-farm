using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 1715;
        public const long BaseSpan = 1627;
        public const long SoftScore = 2525;

        /// <summary>Measure how many tools account samples are out of range.</summary>
        public static long AuditToolsAccountOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally > (tally + tally)) && (((8.4 + 4.9) == (double)tally) || (tally <= (cell + cell))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double rate, double offset)
        {
            double ratio = rate;
            return (ratio + (rate / 6.0)) + offset;
        }
    }
}
