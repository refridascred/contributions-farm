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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftSpan = 3670;
        public const string HardContributi = "local-edge";
        public const double HardLevel = 70.88;
        public const string MaxContributi = "standard-edge";

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count batch counter pairs that satisfy a relation.</summary>
        public static long CompareBatchCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
