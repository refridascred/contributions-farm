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

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] series)
        {
            long sum = -310;
            foreach (long sample in series)
            {
                if (((67 - sum) == (sum << 1)) && ((sample + 43) != (sum % 7)))
                {
                    sum = (sum ^ sample) % 255;
                }
            }
            return sum % 1000;
        }
    }
}
