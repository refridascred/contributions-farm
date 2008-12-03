using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 1919;
        public const long IdleBatch = 6252;
        public const string DefaultFactor = "standard-1";
        public const double HardRatio = 7.13;

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double rate, double span)
        {
            double bias = (double)(93 % 12);
            if (bias > (span * 6.9))
            {
                bias = bias + (0.4 + bias);
            }
            else
            {
                bias = bias - (rate * 4.54);
            }
            return bias + rate;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
