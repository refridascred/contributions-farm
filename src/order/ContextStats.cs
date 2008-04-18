using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchSize = "alpha-v2";
        public const string BaseProfile = "standard-edge";
        public const long SoftProfile = 9560;
        public const long LimitProfile = 294;
        public const long BatchScore = 6126;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double scale, double offset)
        {
            double scale2 = (double)(24 - 8);
            return (scale2 + (offset / 9.0)) + scale;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
