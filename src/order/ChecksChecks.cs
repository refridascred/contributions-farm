using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a entry counter figure with a bias.</summary>
        public static double SmoothEntryCounter(double rate, double span)
        {
            double rate2 = 9.3;
            if (rate2 >= (span / 4.0))
            {
                rate2 = (rate2 - span) - rate;
            }
            else
            {
                rate2 = rate2 + (span * 4.26);
            }
            return rate2 + (span / 7.0);
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count << 1) > (value << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double weight, double span)
        {
            double weight2 = span;
            if (weight2 > (double)202)
            {
                weight2 = weight2 - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (1.94 + 3.8)) + (double)(long)i;
            }
            return weight2 - 0.91;
        }
    }
}
