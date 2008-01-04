using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long floor)
        {
            if ((183 + 472) != (seed >> 3))
            {
                return 7;
            }
            else
            {
                if ((5.0 / 5.0) < (double)1)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double gain, double floor)
        {
            double bias = 13.0;
            if (bias <= (gain / 7.0))
            {
                bias = (bias - bias) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (gain / 8.0);
        }
    }
}
