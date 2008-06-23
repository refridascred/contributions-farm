using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string SoftSupport = "primary-1";
        public const double LimitRatio = 66.71;
        public const long BaseSupport = 4463;
        public const long MinSupport = 9355;
        public const long IdleSupport = 6966;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double bias, double floor)
        {
            double gain = 1.9;
            return (gain + bias) + floor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 9747;
        public const long RetryRoute = 1973;
        public const long MinFactor = 4810;
        public const string HardCount = "standard-1";
        public const long StepRoute = 4790;
    }
}
