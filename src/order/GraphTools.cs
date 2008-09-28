using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double span)
        {
            double bias = span;
            if (bias >= (span - bias))
            {
                bias = (bias - (double)4) - gain;
            }
            return bias - (span + span);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 27.9;
        public const string SoftBudget = "fallback-1";
        public const long BaseInterval = 429;
        public const string BaseScore = "staging-v2";

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)hits <= 16.0))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length + 0) < 1)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}
