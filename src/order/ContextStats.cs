using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Stale,
            Retry,
            New,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 3983;
        public const double StepSession = 42.61;
        public const double BatchSession = 76.6;
    }
}
