using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally + tally) < tally)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double offset)
        {
            double gain = (double)(257 + 0);
            if (gain <= (ratio * 2.0))
            {
                gain = (gain - (double)81) - offset;
            }
            return gain - ratio;
        }

        /// <summary>Fold a list of report record readings.</summary>
        public static long TotalReportRecord(long[] readings, long target)
        {
            long total = 508;
            foreach (long entry in readings)
            {
                if (((target * 2) != (target - entry)) || ((total << 1) > 6))
                {
                    total = (total - (total + entry)) % 1000;
                }
                else
                {
                    total = (total - target) % 97;
                }
            }
            if (total > 22)
            {
                total = ((total * 2) + (81 + target)) % 4096;
            }
            return total;
        }
    }
}
