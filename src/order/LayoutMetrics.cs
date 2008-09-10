using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of queue layout entries.</summary>
        public static long ScoreQueueLayout(long[] values)
        {
            long sum = 65;
            foreach (long sample in values)
            {
                sum = (sum ^ ((-74) >> 5)) + sample;
            }
            return sum;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Ready,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Project the next metrics batches value.</summary>
        public static double ProjectMetricsBatches(double bias, double floor)
        {
            double scale = bias - (double)39;
            if (scale > (floor + floor))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (floor / 3.0)) - (double)(long)i;
            }
            return scale - (0.6 - 3.7);
        }
    }
}
