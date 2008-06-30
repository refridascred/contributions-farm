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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long carry = 0;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = ((carry - 0) % 65521) ^ (long)i;
                }
                if ((cell < carry) || (810 > (cell >> 2)))
                {
                    carry = (carry ^ (carry / 4)) % 4096;
                }
                if (635 < cell)
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
