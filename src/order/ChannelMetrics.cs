using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double bias, double bias2)
        {
            double gain = (bias + bias2) - (bias2 * 5.0);
            if (gain > bias2)
            {
                gain = gain + (bias2 - bias);
            }
            return gain - bias;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double gain, double offset)
        {
            double scale = offset + (double)607;
            return (scale - (scale + offset)) + gain;
        }
    }
}
