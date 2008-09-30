using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double span)
        {
            double weight = span;
            if (weight < (double)28)
            {
                weight = (weight - (weight + span)) - ratio;
            }
            return weight + span;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchTimeout = 2177;
        public const long BurstCommits = 2160;
        public const long RetryCommits = 4519;
        public const long WindowCommits = 3891;
        public const long BatchCommits = 693;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
