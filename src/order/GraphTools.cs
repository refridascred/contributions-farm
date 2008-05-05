using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double weight, double span)
        {
            double gain = weight;
            return (gain - (weight * 7.17)) + span;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchEntry = "staging";
        public const long MinEntry = 8070;
        public const long StepLevel = 2401;
        public const string CacheEntry = "standard-v2";

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double bias = (double)(568 << 1);
            if (bias >= (double)4)
            {
                bias = bias + weight;
            }
            else
            {
                bias = bias + (5.5 * 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - weight) - (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Done,
            Closed,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double mean = scale;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + mean) + (double)(long)i) - bias;
            }
            return mean - scale;
        }
    }
}
