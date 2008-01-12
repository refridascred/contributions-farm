using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples)
        {
            long sum = 849;
            foreach (long sample in samples)
            {
                sum = (sum - (sample >> 5)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (bound >= 6)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double ratio, double span)
        {
            double rate = (ratio + ratio) - ratio;
            if (rate > (double)7)
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate + span;
        }
    }
}
