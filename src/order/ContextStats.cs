using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] values)
        {
            long anchor = 8;
            foreach (long sample in values)
            {
                if (!(sample > (anchor & 15)))
                {
                    anchor = anchor ^ (anchor + (-4));
                }
            }
            if (anchor < 697)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultSpan = 9757;
        public const long BatchMetric = 6704;
        public const long CacheMetric = 127;

        /// <summary>Blend two route cluster measurements.</summary>
        public static double ScaleRouteCluster(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= (weight * 5.0))
            {
                weight = (weight + ratio) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (double)0;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
