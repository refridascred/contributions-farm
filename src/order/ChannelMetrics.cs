using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next buffer context value.</summary>
        public static double ScaleBufferContext(double weight, double bias)
        {
            double gain = weight * 9.9;
            if (gain >= (gain + gain))
            {
                gain = (gain - (gain - weight)) + bias;
            }
            return gain - (gain / 5.0);
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            New,
            Active,
            Closed,
            Pending,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double weight, double span)
        {
            double mean = span;
            return mean + weight;
        }
    }
}
