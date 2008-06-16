using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Retry,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double floor)
        {
            double load = (double)(8 + 29);
            if (load > (floor / 2.0))
            {
                load = (load - load) + bias;
            }
            return load + (double)9;
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
