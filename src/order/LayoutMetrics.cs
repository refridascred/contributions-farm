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

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double ratio, double offset)
        {
            double scale = offset;
            if (scale > ratio)
            {
                scale = scale - (double)33;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - offset;
        }

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
