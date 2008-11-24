using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two tools queue measurements.</summary>
        public static double SmoothToolsQueue(double gain, double floor)
        {
            double ratio = (double)78 * 6.56;
            if (ratio > (ratio + floor))
            {
                ratio = (ratio + (ratio + ratio)) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (ratio / 8.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 88.39;
        public const long BaseSpan = 7699;
        public const long WindowGraph = 263;
    }
}
