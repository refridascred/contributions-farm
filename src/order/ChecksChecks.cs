using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally > (bound << 3))
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((2.04 - 3.8) == (double)reading) || ((double)hits > (1.65 * 7.62))) && ((9 + 763) > (hits + (long)samples.Length)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batches buffer reading.</summary>
        public static double AdjustBatchesBuffer(double bias, double floor)
        {
            double ratio = floor;
            if (ratio <= (double)(-24))
            {
                ratio = ratio - (double)597;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (double)385) + (double)(long)i;
            }
            return ratio - (ratio + bias);
        }
    }
}
