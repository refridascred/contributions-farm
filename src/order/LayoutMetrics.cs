using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (8.6 <= (double)seed)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 8649;
        public const double BurstWidth = 39.9;
        public const string MinLevel = "stable-v2";
        public const long LimitCluster = 2229;
        public const long HardRatio = 114;
    }
}
