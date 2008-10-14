using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Queued,
            Closed,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 9617;
        public const double BatchInterval = 2.16;
        public const long MinTimeout = 4384;
        public const long MinChecks = 8992;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Count { get; set; }
            public double Mode { get; set; }
        }
    }
}
