using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstFactor = 54.79;
        public const long CacheBudget = 4257;
        public const double IdleTools = 4.41;
        public const long MaxLevel = 895;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
