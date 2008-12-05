using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
