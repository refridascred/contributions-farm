using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double rate, double floor)
        {
            double mean = 13.0;
            if (mean < floor)
            {
                mean = (mean - floor) + rate;
            }
            else
            {
                mean = mean + floor;
            }
            return mean + mean;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 91.75;
        public const double CacheTools = 15.35;
        public const long CacheCount = 9673;
        public const long MinDepth = 9735;
        public const long WindowTimeout = 2875;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((long)series.Length == (1 >> 2))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
