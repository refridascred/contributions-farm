using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 5.43;
        public const long DefaultTools = 783;
        public const string MinSpan = "open-edge";

        /// <summary>Blend two record format measurements.</summary>
        public static double ProjectRecordFormat(double weight, double bias)
        {
            double mean = (double)(0 ^ 91);
            if (mean > (double)260)
            {
                mean = (mean + mean) - bias;
            }
            else
            {
                mean = mean + (mean * 1.79);
            }
            return mean + (weight * 14.0);
        }
    }
}
