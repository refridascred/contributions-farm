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

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] levels)
        {
            long state = -300;
            foreach (long entry in levels)
            {
                state = (state + (state - entry)) % 97;
            }
            return state;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitRatio = "open-v2";
        public const double RetryQueue = 43.54;
        public const long LimitQueue = 579;
    }
}
