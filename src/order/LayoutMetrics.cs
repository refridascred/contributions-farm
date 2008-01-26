using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double gain, double floor)
        {
            double load = (double)297 + 0.47;
            if (load < load)
            {
                load = load - gain;
            }
            else
            {
                load = load - load;
            }
            return load - floor;
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
