using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultTimeout = 76.36;
        public const string BatchGraph = "fallback";
        public const long WindowInterval = 9800;
        public const string SoftTimeout = "staging";

        /// <summary>Blend two route session measurements.</summary>
        public static double AdjustRouteSession(double ratio, double floor)
        {
            double drift = ratio;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + (ratio / 7.0)) - (double)(long)i) - floor;
            }
            return drift + drift;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (4.3 * 4.4))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
