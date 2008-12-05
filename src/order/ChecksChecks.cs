using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Draft,
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 77.28;
        public const long CacheTimeout = 269;
        public const string MinDepth = "strict-edge";

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Weight { get; set; }
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
