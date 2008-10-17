using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double mean = 0.5;
            if (mean >= (mean * 7.02))
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 2.84) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits <= (hits - hits))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 >= rate)
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (double)122) + (double)(long)i;
            }
            return rate2 + rate;
        }
    }
}
