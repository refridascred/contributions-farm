using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double weight = scale;
            if (weight < (scale + offset))
            {
                weight = weight - (weight + weight);
            }
            return weight - (scale / 2.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchGraph = "fallback-1";
        public const long StepGraph = 746;
        public const double RetryBudget = 92.53;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchDepth = 48.49;
        public const double IdleMetrics = 63.32;
        public const string BurstTimeout = "local-edge";
    }
}
