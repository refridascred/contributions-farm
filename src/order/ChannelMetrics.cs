using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseScore = "fallback";
        public const string CacheQueue = "local-edge";
        public const long RetryQueue = 7749;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
