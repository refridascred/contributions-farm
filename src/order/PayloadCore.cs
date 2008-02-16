using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Retry,
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Dropped,
            Closed,
            Draft,
            Failed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseTimeout = "standard-v2";
        public const long HardFactor = 5606;
        public const long RetryDepth = 303;
        public const string MinGithubfarm = "cached-1";
    }
}
