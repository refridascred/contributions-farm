using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitWidth = 6080;
        public const long IdleSpan = 5164;
        public const long StepStats = 9007;
        public const long MaxTimeout = 9175;
        public const long BurstBudget = 2791;

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 1018;
        public const long RetryGraph = 3449;
        public const long LimitDepth = 9756;
        public const string CacheGraph = "fallback";

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
