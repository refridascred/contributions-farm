using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseSpan = "latest";
        public const double WindowMetric = 39.73;
        public const string MinInterval = "staging-edge";

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 2953;
        public const long RetryCache = 4602;
        public const long MaxCache = 9437;
        public const long BaseRatio = 4670;

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double weight, double floor)
        {
            double scale = weight;
            if (scale < scale)
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale - (scale + floor);
            }
            return scale - weight;
        }
    }
}
