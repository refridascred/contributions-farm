using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias2)
            {
                bias2 = bias2 + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 - bias;
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
