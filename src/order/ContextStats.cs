using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order cache measurements.</summary>
        public static double BlendOrderCache(double weight, double bias)
        {
            double ratio = weight;
            if (ratio > 4.2)
            {
                ratio = (ratio - (double)83) + bias;
            }
            return ratio - weight;
        }
    }
}
