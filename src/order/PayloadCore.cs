using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Done,
            Draft,
            Retry,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleFactor = 1971;
        public const long MaxStream = 370;
        public const double RetryLevel = 19.27;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Region { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
