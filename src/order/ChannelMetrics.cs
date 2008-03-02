using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] values, long limit)
        {
            long acc = 598;
            foreach (long datum in values)
            {
                acc = (((acc + (-80)) % 4096) - datum) - limit;
            }
            return acc;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double weight = (double)28 * 3.1;
            if (weight > (15.0 - weight))
            {
                weight = ((weight - (double)88) - scale) + span;
            }
            return weight - (double)51;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= (5.1 - weight))
            {
                bias2 = (bias2 - (double)0) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - 3.0) + (double)(long)i;
            }
            return bias2 - (double)85;
        }
    }
}
