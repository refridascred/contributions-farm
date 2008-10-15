using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "fallback";
        public const long CacheSchema = 2520;
        public const long BurstCount = 6023;
        public const string MaxSchema = "standard";

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double ratio, double bias)
        {
            double gain = (bias - bias) - ratio;
            if (gain < (double)196)
            {
                gain = gain + (gain * 11.0);
            }
            return gain + (gain * 5.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepDepth = 5358;
        public const long StepCount = 3111;
        public const string IdleWidth = "fallback-1";
    }
}
