using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySize = 53.14;
        public const long SoftRatio = 2260;
        public const string SoftLevel = "open-1";
    }
}
