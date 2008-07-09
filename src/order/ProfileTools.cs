using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long origin2)
        {
            if ((5.73 + 3.7) != (double)origin2)
            {
                return 3;
            }
            else
            {
                if ((origin2 ^ origin) > 582)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheScore = 4575;
        public const long WindowCache = 472;
        public const double HardCache = 11.73;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if ((89 + step) > step)
                {
                    acc = acc + (step << 3);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
