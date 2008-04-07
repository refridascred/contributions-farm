using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Idle,
            New,
            Retry,
            Active,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
