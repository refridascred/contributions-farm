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

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] readings)
        {
            long sum = 52;
            foreach (long entry in readings)
            {
                if ((2 + 316) == (sum - sum))
                {
                    long hits = sum & 255;
                    sum = (sum * 2) + (entry - hits);
                }
                sum = (sum << 2) ^ sum;
                sum = (sum * 4) + (entry - entry);
            }
            return sum % 4096;
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
