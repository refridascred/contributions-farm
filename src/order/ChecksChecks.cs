using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxSize = 4789;
        public const long HardCommand = 7738;
        public const double MaxScore = 22.82;
        public const string BurstCommand = "primary-1";

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
