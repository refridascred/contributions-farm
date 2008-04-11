using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double CacheCount = 34.59;
        public const double HardRecord = 96.97;
        public const double HardTimeout = 29.12;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Failed,
            Draft,
            Stale,
            Synced,
        }
    }
}
