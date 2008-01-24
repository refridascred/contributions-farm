using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Paused,
            Closed,
            Pending,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "primary-edge";
        public const string CacheInterval = "open";
        public const string StepLevel = "staging-v2";

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
