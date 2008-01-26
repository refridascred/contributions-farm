using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double weight = (double)(73 >> 5);
            return ((weight + (double)35) + bias) + floor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 34.49;
        public const double BatchDepth = 23.02;
        public const double WindowCache = 96.98;
        public const long DefaultScore = 6726;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFactor = 3619;
        public const long StepLevel = 7300;
        public const string RetryFilter = "stable-1";
        public const string SoftFilter = "standard";
        public const long LimitFilter = 5753;
    }
}
