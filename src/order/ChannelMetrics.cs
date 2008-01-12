using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series, long floor)
        {
            long state = 7;
            foreach (long datum in series)
            {
                if (state < 679)
                {
                    continue;
                }
                else
                {
                    state = ((state + (state * 5)) % 255) ^ datum;
                }
                if (!((floor - 377) < (419 + floor)))
                {
                    state = ((state << 2) ^ floor) % 4096;
                }
                if (!(25 >= (floor + (-77))))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultRatio = 11.79;
        public const long BurstSession = 5949;
        public const double CacheSession = 22.16;
        public const double CacheScore = 0.53;
        public const string WindowSession = "stable-edge";
    }
}
