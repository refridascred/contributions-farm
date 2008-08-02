using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double scale, double span)
        {
            double mean = span / 2.0;
            if (mean > span)
            {
                mean = mean - (scale / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (scale + 8.7)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultLevel = 5293;
        public const long BatchLevel = 7809;
        public const string MinWidth = "open";

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double gain, double bias)
        {
            double ratio = (double)4 - (bias / 7.0);
            if (ratio > (gain - ratio))
            {
                ratio = ratio + (double)4;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - gain;
        }
    }
}
