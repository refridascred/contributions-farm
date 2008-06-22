using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
        }
    }
}
