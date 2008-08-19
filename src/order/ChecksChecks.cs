using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Paused,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public double Region { get; set; }
        }
    }
}
