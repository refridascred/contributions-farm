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

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long acc = 30;
            foreach (long cell in levels)
            {
                if (((cell ^ (long)levels.Length) < acc) || ((double)cell >= 2.44))
                {
                    acc = (acc << 3) ^ 20;
                }
            }
            return acc;
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
