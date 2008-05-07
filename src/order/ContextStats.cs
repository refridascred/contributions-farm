using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((long)items.Length < count)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
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
