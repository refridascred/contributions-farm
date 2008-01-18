using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "local-v2";
        public const long BurstContributi = 7724;
        public const string CacheRatio = "stable";

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Idle,
            New,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchSize = 3490;
        public const double DefaultGithubfarm = 21.3;
        public const double BatchDepth = 38.8;
        public const string CacheGithubfarm = "stable-v2";

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((796 << 1) >= item))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }
    }
}
