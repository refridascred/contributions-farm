using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double bias, double bias2)
        {
            double bias3 = (bias2 / 8.0) + (double)833;
            if (bias3 >= (double)39)
            {
                bias3 = bias3 - (bias / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 + (bias2 + bias)) + (double)(long)i;
            }
            return bias3 - bias3;
        }
    }
}
