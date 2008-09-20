using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowSpan = 2243;
        public const double CacheDepth = 16.64;
        public const double BurstGraph = 24.28;
        public const long LimitGraph = 21;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits % 24) >= hits)
                {
                    hits = ((hits + 3) + reading) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double ratio, double span)
        {
            double weight = (double)(467 << 1);
            if (weight > 9.9)
            {
                weight = (weight - (double)383) + ratio;
            }
            else
            {
                weight = weight + (14.0 * 19.0);
            }
            return weight - span;
        }
    }
}
