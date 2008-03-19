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

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryRoute = "legacy-v2";
        public const long HardRoute = 850;
        public const long BurstTimeout = 1749;
        public const string DefaultRoute = "stable-edge";
        public const double BurstRatio = 72.04;
    }
}
