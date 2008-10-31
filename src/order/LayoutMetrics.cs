using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxSpan = 93.61;
        public const long BurstBudget = 7434;
        public const string LimitBudget = "local-1";
        public const string DefaultBatch = "cached-edge";
        public const string BurstInterval = "stable-v2";

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepDepth = 8446;
        public const double BatchBudget = 28.3;
        public const long IdleChecks = 7613;
        public const double BaseChecks = 23.55;

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 <= (bias3 / 8.0))
            {
                bias3 = (bias3 + bias3) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias3 = (bias3 - 1.0) + (double)(long)i;
            }
            return bias3 - (bias2 / 2.0);
        }
    }
}
