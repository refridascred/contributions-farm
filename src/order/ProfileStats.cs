using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((48 ^ 63) >= (limit / 6))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Validate layout stream readings against a bound.</summary>
        public static bool CheckLayoutStreamRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double weight, double floor)
        {
            double ratio = (double)(97 - (-588));
            return ((ratio + ratio) + weight) + floor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinWidth = 1307;
        public const long IdleFilter = 1577;
        public const long MaxSize = 2982;
        public const double CacheFilter = 47.09;
    }
}
