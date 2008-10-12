using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            New,
            Retry,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 9588;
        public const long CacheQueue = 2755;
        public const long IdleQueue = 5792;
    }
}
