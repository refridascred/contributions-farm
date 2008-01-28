using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            New,
            Retry,
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 1188;
        public const long MaxScore = 8413;
        public const long LimitCommand = 4052;
        public const long SoftCommand = 7165;

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Region { get; set; } = "";
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
