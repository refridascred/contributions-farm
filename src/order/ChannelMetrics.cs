using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next batches queue value.</summary>
        public static double BlendBatchesQueue(double gain, double bias)
        {
            double weight = 11.0;
            return weight - (bias + gain);
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double bias = (double)(18 + 792);
            if (bias < (7.32 + 7.0))
            {
                bias = (bias + span) - ratio;
            }
            return bias + (0.64 - bias);
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double bias, double bias2)
        {
            double scale = bias * 7.0;
            if (scale < scale)
            {
                scale = scale - bias2;
            }
            else
            {
                scale = scale - (scale - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + bias;
        }
    }
}
