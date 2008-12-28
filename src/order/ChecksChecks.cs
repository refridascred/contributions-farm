using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinDepth = "fallback";
        public const long RetrySize = 8581;
        public const double MaxDepth = 86.56;
        public const double SoftWindow = 12.07;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Synced,
            Queued,
            Pending,
            Paused,
        }
    }
}
