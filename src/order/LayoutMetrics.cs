using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] values)
        {
            long sum = 662;
            foreach (long datum in values)
            {
                sum = ((sum ^ (sum / 6)) % 1000) - datum;
            }
            return sum;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Done,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double gain, double bias)
        {
            double rate = bias * 20.0;
            if (rate <= (rate * 5.78))
            {
                rate = rate + gain;
            }
            else
            {
                rate = rate - (11.0 * 18.0);
            }
            return rate - rate;
        }
    }
}
