using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a commits cache figure with a bias.</summary>
        public static double ProjectCommitsCache(double bias, double floor)
        {
            double drift = bias;
            if (drift <= floor)
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift - (floor / 3.0);
            }
            return drift + bias;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            New,
            Idle,
            Paused,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double load = bias;
            for (int i = 0; i < 8; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load + (load + bias);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitGithubfarm = "latest-1";
        public const long RetryGithubfarm = 5042;
        public const double SoftDepth = 71.51;
        public const long BatchLevel = 2973;
        public const long HardGithubfarm = 7463;
    }
}
