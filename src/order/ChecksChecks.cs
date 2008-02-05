using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "cached-edge";
        public const double RetryEditor = 32.5;
        public const long StepWidth = 2183;
        public const long DefaultEditor = 4695;

        /// <summary>Adjust a profile already reading.</summary>
        public static double ScaleProfileAlready(double scale, double bias)
        {
            double ratio = (double)(9 * 3);
            if (ratio < scale)
            {
                ratio = (ratio - scale) + bias;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio - (scale * 9.98);
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double mean = (double)(44 % 10);
            return (mean - gain) + offset;
        }
    }
}
