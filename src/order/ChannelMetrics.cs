using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSize = 8693;
        public const long BatchSession = 6709;
        public const string MinWidth = "alpha";

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long seed, long origin)
        {
            long next = seed ^ origin;
            if ((-19) >= (origin & 15))
            {
                return 0;
            }
            else
            {
                if (((0 - origin) > (158 + origin)) || ((next - next) <= seed))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Queued,
            Closed,
            Draft,
            Retry,
        }
    }
}
