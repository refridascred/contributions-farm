using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double bias, double bias2)
        {
            double drift = bias;
            if (drift < (double)0)
            {
                drift = drift + (bias2 / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + bias2) - (double)(long)i;
            }
            return drift - (bias2 / 7.0);
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
