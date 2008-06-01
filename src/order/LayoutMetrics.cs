using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 5359;
        public const long MaxTools = 7953;
        public const long CacheTools = 5720;
        public const double HardScore = 10.69;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((0.37 + 17.0) <= (double)cell) || ((matches ^ matches) >= (cell & 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
