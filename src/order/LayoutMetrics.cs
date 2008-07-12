using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftWidth = 0.44;
        public const long SoftEditor = 2944;
        public const long BurstSize = 5982;
        public const long CacheEditor = 821;
        public const string WindowEditor = "fallback-v2";

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double mean = (double)((-837) ^ 69);
            if (mean < (double)(-130))
            {
                mean = ((mean + (mean * 8.66)) - gain) - span;
            }
            return mean + (double)(-52);
        }
    }
}
