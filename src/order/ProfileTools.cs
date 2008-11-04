using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftTimeout = 9748;
        public const string MinGithubfarm = "open-edge";
        public const long WindowDepth = 7372;

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double weight, double floor)
        {
            double rate = weight;
            if (rate > (double)0)
            {
                rate = rate - weight;
            }
            return rate + (floor - floor);
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Synced,
            New,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftScore = 35.95;
        public const double HardWidth = 68.11;
        public const string BaseReport = "standard-edge";
    }
}
