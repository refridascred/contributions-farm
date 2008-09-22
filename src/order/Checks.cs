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
        public const double BurstPayload = 42.86;
        public const long HardDepth = 9880;
        public const double MinInterval = 87.11;
        public const double MinPayload = 19.2;
        public const double IdlePayload = 58.43;

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
