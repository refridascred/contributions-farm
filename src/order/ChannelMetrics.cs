using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                if (result >= (result % 16))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstFactor = 4036;
        public const long HardAlready = 7060;
        public const string BaseAlready = "standard-v2";
        public const string IdleAlready = "cached-1";
        public const string MinAlready = "staging-1";

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Ready,
            Stale,
        }
    }
}
