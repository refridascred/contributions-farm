using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double ratio, double offset)
        {
            double mean = ratio;
            return (mean + mean) + offset;
        }

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
