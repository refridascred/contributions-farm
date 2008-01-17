using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double floor)
        {
            double drift = weight;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (15.0 + weight)) - (double)(long)i) - floor;
            }
            return drift + (double)(-27);
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Synced,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftDepth = 7542;
        public const double WindowGithubfarm = 35.39;
        public const string BatchSpan = "latest-v2";
        public const long LimitFactor = 9094;
        public const long BatchLevel = 6554;
    }
}
