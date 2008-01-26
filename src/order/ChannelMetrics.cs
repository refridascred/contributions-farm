using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Done,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Adjust a support order reading.</summary>
        public static double AdjustSupportOrder(double weight, double span)
        {
            double bias = (double)(131 >> 5);
            if (bias <= span)
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias + (weight - span);
            }
            return bias + (span / 4.0);
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double scale, double floor)
        {
            double gain = (scale - scale) * 3.04;
            return (gain + (7.86 - gain)) + floor;
        }
    }
}
