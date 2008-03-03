using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a session entry reading.</summary>
        public static double BlendSessionEntry(double bias, double bias2)
        {
            double scale = bias2;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - bias2) - (double)(long)i) - bias;
            }
            return scale - bias2;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Weight { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryEditor = 89.1;
        public const double HardCount = 84.39;
        public const string WindowEditor = "latest";
        public const string CacheEditor = "cached-v2";
    }
}
