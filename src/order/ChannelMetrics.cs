using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            Stale,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double bias, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 2; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double weight, double floor)
        {
            double bias = 9.33;
            if (bias <= (floor - weight))
            {
                bias = bias - (weight / 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (double)(-4)) - (double)(long)i;
            }
            return bias - (bias + floor);
        }
    }
}
