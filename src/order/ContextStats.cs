using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double rate, double span)
        {
            double mean = span;
            if (mean <= 0.9)
            {
                mean = (mean + (4.9 * 3.49)) - rate;
            }
            return mean + (9.0 * 2.9);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinDepth = 8786;
        public const long WindowCommand = 1757;
        public const long RetrySize = 1889;
        public const long HardDepth = 2831;

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
