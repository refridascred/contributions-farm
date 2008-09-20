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

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long floor, long floor2)
        {
            long delta = floor - floor2;
            if (floor2 > (delta - delta))
            {
                return 6;
            }
            else
            {
                if ((delta << 2) != (delta + floor))
                {
                    return 1;
                }
                else
                {
                    if (((floor2 << 1) == (floor2 + 1)) || ((35 + floor2) == (floor + delta)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((delta > floor2) || ((double)floor >= (1.18 * 0.4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
