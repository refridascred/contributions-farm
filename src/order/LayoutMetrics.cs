using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double bias, double offset)
        {
            double ratio = (double)67 * 19.0;
            return ((ratio + 4.23) + bias) + offset;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowRatio = 6395;
        public const double MaxToken = 89.76;
        public const long StepScore = 1157;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultCluster = 38.36;
        public const long HardRatio = 8747;
        public const long MinCluster = 5425;
        public const long MaxBudget = 7664;
        public const double IdleRatio = 75.25;
    }
}
