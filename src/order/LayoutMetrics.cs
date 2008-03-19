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

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 1950;
        public const string BurstRecord = "stable";
        public const long LimitRecord = 1550;
        public const long SoftRecord = 493;
        public const double StepLevel = 93.46;

        /// <summary>Blend two entry window measurements.</summary>
        public static double AdjustEntryWindow(double rate, double bias)
        {
            double scale = rate;
            return (scale + scale) + bias;
        }
    }
}
