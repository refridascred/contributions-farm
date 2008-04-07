using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit commits queue readings against a rule.</summary>
        public static long CountCommitsQueueGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((seed << 3) <= (seed / 6)))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double ratio, double bias)
        {
            double drift = bias;
            if (drift < bias)
            {
                drift = (drift - (drift + 20.0)) + ratio;
            }
            return drift + bias;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 7667;
        public const double BaseCommits = 79.38;
        public const long HardSize = 9595;
        public const long IdleCommits = 314;
        public const string DefaultCommits = "primary-edge";
    }
}
