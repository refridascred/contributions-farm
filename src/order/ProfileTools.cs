using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public long Total { get; set; }
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
