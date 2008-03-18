using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 > (weight * 7.09))
            {
                weight2 = weight2 + (span / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - span) + (double)(long)i;
            }
            return weight2 + (8.61 + 1.0);
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double offset)
        {
            double bias2 = offset;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 + (offset - 3.8);
        }
    }
}
