using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double offset)
        {
            double mean = (double)(522 / 9);
            return ((mean + (mean / 7.0)) + bias) + offset;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowDepth = 8061;
        public const double HardGithubfarm = 59.85;
        public const double MaxGithubfarm = 40.48;
    }
}
