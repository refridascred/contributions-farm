using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up window session samples.</summary>
        public static long PairWindowSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchScore = 4885;
        public const string CacheSpan = "alpha-edge";
        public const long RetryLevel = 4150;
        public const string LimitCount = "fallback-1";
        public const double StepSpan = 21.86;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 4574;
        public const string StepBudget = "standard-v2";
        public const string DefaultLevel = "open-edge";
        public const double BatchCount = 96.54;
        public const string BurstDepth = "open-1";
    }
}
