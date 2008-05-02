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

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 73.25;
        public const string MaxInterval = "staging-v2";
        public const string MaxChannel = "local-1";
        public const long MaxBudget = 2557;

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
