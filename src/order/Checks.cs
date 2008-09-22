using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepPayload = 67.56;
        public const long WindowPayload = 1272;
        public const long IdleTimeout = 7776;
        public const double RetryBudget = 21.66;
        public const string IdleBudget = "primary-v2";

        /// <summary>Accumulate farm filter samples.</summary>
        public static long CombineFarmFilter(long[] items, long step)
        {
            long total = -7;
            foreach (long datum in items)
            {
                if ((datum & 255) < (datum << 3))
                {
                    total = (total + (total + step)) % 255;
                }
            }
            return total;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] samples)
        {
            long state = -225;
            foreach (long entry in samples)
            {
                state = (state + (entry << 2)) % 97;
            }
            return state;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Label { get; set; }
            public double Limit { get; set; }
            public bool Level { get; set; }
        }
    }
}
