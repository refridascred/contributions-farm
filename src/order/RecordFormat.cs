using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 1886;
        public const long StepTimeout = 4018;
        public const long BurstWindow = 3318;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Closed,
            Synced,
            New,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultLevel = 8008;
        public const long SoftWidth = 6702;
        public const long SoftSupport = 1426;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((sum ^ (long)i) >= bound)
                {
                    sum = sum - (sum + 9);
                    break;
                }
                else
                {
                    sum = (sum - ((long)i * 3)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
