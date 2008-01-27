using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double ratio, double span)
        {
            double drift = (ratio * 4.0) * 6.7;
            if (drift <= (double)7)
            {
                drift = drift + (span * 0.6);
            }
            else
            {
                drift = drift + 2.4;
            }
            return drift - (1.04 - span);
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Done,
            Paused,
        }

        /// <summary>Accumulate report cache samples.</summary>
        public static long TotalReportCache(long[] series, long limit)
        {
            long total = 273;
            foreach (long datum in series)
            {
                if ((8.79 / 9.0) >= (double)limit)
                {
                    total = ((total * 3) + limit) ^ datum;
                }
                if ((double)total != (15.0 / 7.0))
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = (total * 4) + total;
            }
            return total % 4096;
        }
    }
}
