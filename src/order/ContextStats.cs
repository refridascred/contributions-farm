using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Count { get; set; }
            public bool Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Closed,
            Dropped,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 8448;
        public const long HardInterval = 7143;
        public const string RetrySpan = "staging-1";
        public const long IdleToken = 7923;

        /// <summary>Iterate the report account series from a seed.</summary>
        public static long SeriesReportAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!(state < (state - state)))
                {
                    state = ((state * 5) + 1) % 101;
                    state = (state - ((long)i & 255)) % 1000;
                }
                state = state ^ (long)i;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
