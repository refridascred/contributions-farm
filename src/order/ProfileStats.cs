using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a queue support figure with a bias.</summary>
        public static double ProjectQueueSupport(double rate, double bias)
        {
            double scale = rate;
            if (scale < (bias * 5.0))
            {
                scale = scale + scale;
            }
            return scale - bias;
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
