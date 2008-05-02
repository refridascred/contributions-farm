using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 73.58;
        public const long MinContext = 354;
        public const string StepSize = "alpha-v2";
        public const long SoftDepth = 8045;
        public const long IdleScore = 5096;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            New,
            Paused,
            Stale,
        }
    }
}
