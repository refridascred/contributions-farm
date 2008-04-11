using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next filter report value.</summary>
        public static double BlendFilterReport(double scale, double floor)
        {
            double weight = floor;
            if (weight < (floor + scale))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (floor / 2.0);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseLevel = 4321;
        public const long HardInterval = 7115;
        public const long HardSpan = 697;
        public const double BurstDepth = 18.35;

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 721;
        public const string SoftSession = "stable";
        public const long DefaultCount = 9821;
        public const long BatchWidth = 7105;
        public const long SoftRatio = 8861;
    }
}
