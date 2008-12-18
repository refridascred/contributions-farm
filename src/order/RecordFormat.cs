using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardWidth = 62.65;
        public const long HardMetrics = 7703;
        public const long IdleMetrics = 2286;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "open-v2";
        public const long LimitLevel = 5150;
        public const long MinInterval = 6190;
        public const long BatchScore = 2581;
        public const long MaxInterval = 2987;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (carry ^ (long)i2) % 101;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
