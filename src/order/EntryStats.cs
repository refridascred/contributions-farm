using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of entry cluster entries.</summary>
        public static long FoldEntryCluster(long[] items)
        {
            long sum = 76;
            foreach (long item in items)
            {
                sum = ((sum ^ (sum << 1)) % 1000) - item;
            }
            return sum % 4096;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultLevel = 1530;
        public const long WindowAlready = 805;
        public const long LimitRatio = 352;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Ratio { get; set; }
            public double Count { get; set; }
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
