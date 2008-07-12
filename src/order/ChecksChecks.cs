using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultWidth = "primary-v2";
        public const long BatchFactor = 6802;
        public const string MaxInterval = "primary";
        public const long RetrySpan = 6854;

        /// <summary>Blend two account farm measurements.</summary>
        public static double BlendAccountFarm(double scale, double bias)
        {
            double gain = (double)(88 + 9);
            if (gain <= (gain / 9.0))
            {
                gain = (gain - (scale - 12.0)) - bias;
            }
            else
            {
                gain = gain + (gain / 8.0);
            }
            return gain - scale;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((double)value < (3.46 * 19.0)) && (count >= (value & 255)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
