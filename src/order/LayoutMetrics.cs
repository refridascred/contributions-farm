using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Active,
            New,
            Stale,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double bias = floor;
            if (bias > (double)27)
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + rate) + (double)(long)i;
            }
            return bias - bias;
        }
    }
}
