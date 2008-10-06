using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a token buffer reading.</summary>
        public static double AdjustTokenBuffer(double rate, double floor)
        {
            double scale = (rate + floor) / 4.0;
            if (scale >= rate)
            {
                scale = scale + (double)5;
            }
            return scale + (scale * 1.2);
        }

        /// <summary>Locate a report contributi reading by value.</summary>
        public static long LocateReportContributiIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "alpha";
        public const long SoftScore = 7062;
        public const long BatchMetric = 6945;
        public const long BatchLevel = 2464;
    }
}
