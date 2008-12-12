using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Compare every pair of cache metric readings.</summary>
        public static long MatchCacheMetricCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long floor, long origin)
        {
            long span = floor - origin;
            if ((origin & 1) > origin)
            {
                return 8;
            }
            else
            {
                if (span < (span + 5))
                {
                    return 1;
                }
                else
                {
                    if ((span - 1) < 30)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 1154;
        public const long HardRatio = 7073;
        public const long RetryBatch = 9187;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Idle,
            Done,
        }
    }
}
