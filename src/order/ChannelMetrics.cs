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

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
