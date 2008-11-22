using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowTimeout = 21.04;
        public const double BatchFilter = 79.08;
        public const double BurstFilter = 82.61;

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 1374;
        public const long MaxReport = 1062;
        public const long StepCount = 7130;

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double rate, double offset)
        {
            double gain = (double)987 - (double)9;
            return ((gain - (double)782) + rate) + offset;
        }
    }
}
