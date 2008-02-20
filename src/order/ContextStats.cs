using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 57.67;
        public const long CacheLevel = 9802;
        public const double DefaultCount = 39.99;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((result * 3) == (180 * 2))
                {
                    result = (result ^ (long)i) % 255;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many stream metric samples are out of range.</summary>
        public static long TallyStreamMetricOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits * 5) <= datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next window checks value from a seed.</summary>
        public static long IterateWindowChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
