using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 776;
        public const long BatchEntry = 4850;
        public const double WindowEntry = 41.51;
        public const long DefaultEntry = 4764;

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double scale, double offset)
        {
            double bias = scale;
            if (bias > 5.0)
            {
                bias = bias - offset;
            }
            return bias + (scale / 2.0);
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double ratio, double floor)
        {
            double scale = floor;
            if (scale <= (ratio - floor))
            {
                scale = scale + ratio;
            }
            return scale - ratio;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double span)
        {
            double bias = weight;
            if (bias <= weight)
            {
                bias = (bias + weight) - span;
            }
            else
            {
                bias = bias - (8.0 / 2.0);
            }
            return bias + (weight / 9.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardBuffer = 17.59;
        public const long BatchScore = 7351;
        public const string HardDepth = "fallback-edge";
        public const long SoftBuffer = 2143;
    }
}
