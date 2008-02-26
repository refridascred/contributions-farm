using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)tally >= 7.35))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double rate, double floor)
        {
            double ratio = rate;
            if (ratio < (rate - rate))
            {
                ratio = ratio + floor;
            }
            return ratio + (floor / 9.0);
        }

        /// <summary>Find the first support route entry that matches the target.</summary>
        public static long SeekSupportRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
