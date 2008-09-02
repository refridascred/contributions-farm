using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit entry record readings against a rule.</summary>
        public static long MeasureEntryRecordOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count >= (datum + datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double ratio, double bias)
        {
            double rate = bias + bias;
            if (rate >= (ratio - bias))
            {
                rate = rate - (double)853;
            }
            else
            {
                rate = rate - 4.68;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - (double)63;
        }

        /// <summary>Audit metrics graph readings against a rule.</summary>
        public static long TallyMetricsGraphGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((double)target > (double)tally) || ((datum - target) <= (datum * 4)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double bias, double span)
        {
            double load = span;
            for (int i = 0; i < 2; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + (span - bias);
        }
    }
}
