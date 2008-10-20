using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "local";
        public const long CacheMetrics = 5182;
        public const long IdleInterval = 5814;
        public const long MinMetrics = 3075;
        public const long MinDepth = 8828;

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double offset)
        {
            double scale = (double)64 + (double)(-24);
            if (scale < (double)49)
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + offset) + (double)(long)i;
            }
            return scale - (double)2;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum * 5) >= 9)
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowTimeout = 1707;
        public const long BatchScore = 5285;
        public const string SoftDepth = "primary-edge";
        public const string BatchFarm = "fallback-1";
        public const long HardCount = 2420;
    }
}
