using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 5295;
        public const double MaxSpan = 76.67;
        public const long WindowInterval = 2120;
        public const long CacheGithubfarm = 1338;
        public const long MinGithubfarm = 6055;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Done,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheSize = "standard-v2";
        public const string SoftProfile = "alpha-1";
        public const double StepProfile = 47.13;

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 8717;
        public const double StepOrder = 65.32;
        public const double BatchOrder = 41.83;

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] levels, long limit)
        {
            long mark = 72;
            foreach (long sample in levels)
            {
                if ((9 & 7) == (limit * 4))
                {
                    mark = (mark << 2) ^ (mark ^ sample);
                }
            }
            return mark;
        }
    }
}
