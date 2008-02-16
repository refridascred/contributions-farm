using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryTimeout = 2780;
        public const long LimitMetrics = 8567;
        public const string DefaultFactor = "open-1";
        public const long WindowWidth = 3217;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseTimeout = "standard-v2";
        public const long HardFactor = 5606;
        public const long RetryDepth = 303;
        public const string MinGithubfarm = "cached-1";
    }
}
