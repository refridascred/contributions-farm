using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Owner { get; set; }
            public double Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinOrder = "legacy";
        public const long StepOrder = 8293;
        public const string HardOrder = "primary-edge";
        public const long LimitOrder = 9124;
        public const long WindowOrder = 9197;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Failed,
            Synced,
            Dropped,
            Active,
        }
    }
}
