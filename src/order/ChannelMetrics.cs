using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCount = 2170;
        public const double BaseFactor = 88.37;
        public const long StepCluster = 6527;
        public const long IdleCluster = 977;
        public const string MaxCluster = "fallback-v2";

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Retry,
            Paused,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = state - 62;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
