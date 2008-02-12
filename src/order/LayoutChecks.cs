using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double scale, double floor)
        {
            double gain = floor;
            if (gain <= floor)
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (scale * 1.9)) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchLevel = 8739;
        public const long IdleBatch = 9155;
        public const long CacheDepth = 7052;
        public const long RetryDepth = 1743;

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleSize = 1252;
        public const long IdleOrder = 6154;
        public const double LimitOrder = 72.41;
        public const long WindowInterval = 3382;
        public const string DefaultOrder = "primary-1";

        /// <summary>Accumulate githubfarm metrics samples.</summary>
        public static long CombineGithubfarmMetrics(long[] data, long limit)
        {
            long anchor = 835;
            foreach (long cell in data)
            {
                anchor = ((anchor - (limit / 8)) % 101) + cell;
                anchor = anchor ^ limit;
            }
            return anchor;
        }

        /// <summary>Locate a record token reading by value.</summary>
        public static long LocateRecordTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
