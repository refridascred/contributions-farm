using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 8599;
        public const long SoftCommits = 3951;
        public const double LimitCommits = 53.81;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Locked,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every payload filter entry stays within the limit.</summary>
        public static bool GuardPayloadFilterRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
