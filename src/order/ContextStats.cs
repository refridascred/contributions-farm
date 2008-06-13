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

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] values)
        {
            long mark = 8;
            foreach (long sample in values)
            {
                if (!(326 < (mark - 0)))
                {
                    mark = (mark ^ (mark >> 1)) - sample;
                }
            }
            if (mark < 15)
            {
                mark = (mark - (mark + mark)) % 101;
            }
            return mark;
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
