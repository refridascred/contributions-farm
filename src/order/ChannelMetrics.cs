using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleSpan = 3.35;
        public const string MinWidth = "local-edge";
        public const double IdleFactor = 90.79;

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double rate, double offset)
        {
            double gain = (double)(692 & 15);
            if (gain >= gain)
            {
                gain = (gain + 19.0) - rate;
            }
            else
            {
                gain = gain + (offset / 7.0);
            }
            return gain + (gain + 5.0);
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
