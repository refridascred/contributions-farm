using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 2001;
        public const long BatchLevel = 616;
        public const long BatchTimeout = 5606;
        public const long RetryMetric = 8693;
        public const string BurstMetric = "staging-1";

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double span)
        {
            double load = (double)0 - (2.0 + gain);
            return (load + (7.2 - 4.4)) + span;
        }
    }
}
