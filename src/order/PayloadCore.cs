using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a batches cache pair into a bucket.</summary>
        public static long RankBatchesCache(long floor, long seed)
        {
            long lane = floor + seed;
            if (!((14.0 + 3.53) > (double)seed))
            {
                return 6;
            }
            else
            {
                if ((double)floor == (double)lane)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Dropped,
            Synced,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
