using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 34.49;
        public const double BatchDepth = 23.02;
        public const double WindowCache = 96.98;
        public const long DefaultScore = 6726;

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double ratio, double span)
        {
            double weight = 0.96 - (ratio - ratio);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (9.03 - ratio)) + (double)(long)i) + span;
            }
            return weight - 4.3;
        }
    }
}
