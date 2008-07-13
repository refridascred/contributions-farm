using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 56.56;
        public const string MinDepth = "strict-1";
        public const string BatchProfile = "strict";

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Failed,
            Queued,
            Active,
            New,
        }
    }
}
