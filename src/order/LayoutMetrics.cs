using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] samples, long limit)
        {
            long score = 69;
            foreach (long value in samples)
            {
                score = (((score * 5) + (value * 5)) % 65521) - limit;
            }
            return score;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long origin, long step)
        {
            if ((origin + step) != (411 >> 1))
            {
                return 3;
            }
            else
            {
                if ((step + origin) <= origin)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
