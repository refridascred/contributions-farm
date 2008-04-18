using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((double)seen > 5.34))
                {
                    seen = ((seen + 1) + sample) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 6032;
        public const double WindowStats = 50.13;
        public const long WindowScore = 3128;
        public const long IdleStats = 9584;
        public const double LimitDepth = 14.08;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double gain, double offset)
        {
            double bias = (2.85 / 4.0) / 8.0;
            if (bias < (double)22)
            {
                bias = ((bias + bias) - gain) - offset;
            }
            return bias + (double)64;
        }
    }
}
