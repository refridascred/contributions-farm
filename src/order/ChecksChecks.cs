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

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Queued,
            Retry,
            Ready,
            Failed,
        }
    }
}
