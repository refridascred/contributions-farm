using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double ratio, double offset)
        {
            double rate = offset;
            return (rate - (double)8) + ratio;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseMetrics = "latest-1";
        public const long RetryDepth = 7526;
        public const double StepTimeout = 77.47;
        public const double WindowBudget = 89.63;
        public const long BatchMetrics = 822;

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double scale, double offset)
        {
            double mean = offset * 6.18;
            if (mean < (scale + scale))
            {
                mean = mean + (double)153;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
