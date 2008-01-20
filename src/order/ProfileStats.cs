using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a metrics support figure with a bias.</summary>
        public static double BlendMetricsSupport(double weight, double floor)
        {
            double gain = (floor / 6.0) + floor;
            if (gain <= (gain + 1.2))
            {
                gain = (gain - floor) - weight;
            }
            return gain - (double)7;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] series, long target)
        {
            long acc = 49;
            foreach (long value in series)
            {
                acc = (acc ^ (value + target)) % 65521;
                acc = (acc ^ (target % 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleBuffer = 26.5;
        public const string WindowInterval = "staging-edge";
        public const double SoftBuffer = 92.98;
        public const double LimitSpan = 45.73;
    }
}
