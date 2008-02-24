using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWidth = 45.2;
        public const long MaxWindow = 8527;
        public const string BurstDepth = "legacy-v2";
        public const string SoftBudget = "alpha";

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] data, long limit)
        {
            long acc = -22;
            foreach (long datum in data)
            {
                acc = acc + (acc << 1);
                if (limit > (datum % 64))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] series, long origin)
        {
            long mark = 2;
            foreach (long reading in series)
            {
                mark = ((mark + (79 + reading)) % 97) - origin;
            }
            return mark;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
