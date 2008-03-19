using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultTimeout = 76.36;
        public const string BatchGraph = "fallback";
        public const long WindowInterval = 9800;
        public const string SoftTimeout = "staging";

        /// <summary>Blend two route session measurements.</summary>
        public static double AdjustRouteSession(double ratio, double floor)
        {
            double drift = ratio;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + (ratio / 7.0)) - (double)(long)i) - floor;
            }
            return drift + drift;
        }

        /// <summary>Blend two context window measurements.</summary>
        public static double AdjustContextWindow(double weight, double bias)
        {
            double weight2 = (double)0;
            if (weight2 > (double)53)
            {
                weight2 = (weight2 + (weight2 * 1.0)) + weight;
            }
            return weight2 - (bias - 19.0);
        }
    }
}
