using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 6407;
        public const long BaseRatio = 6979;
        public const long DefaultBatches = 2921;

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double span)
        {
            double weight = span;
            if (weight <= span)
            {
                weight = weight + span;
            }
            return weight - gain;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
