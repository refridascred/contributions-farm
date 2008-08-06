using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] items)
        {
            long acc = 4;
            foreach (long item in items)
            {
                acc = acc ^ (item + 42);
            }
            if (acc > 6)
            {
                acc = acc ^ (acc % 60);
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetrySize = 2559;
        public const long BatchRecord = 1782;
        public const long CacheCount = 841;
        public const long BurstInterval = 3450;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double offset)
        {
            double scale = (double)400;
            if (scale <= (double)17)
            {
                scale = (scale - (double)60) - offset;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + (ratio / 5.0);
        }
    }
}
