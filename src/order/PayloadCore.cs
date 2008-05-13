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

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] levels, long step)
        {
            long acc = 3;
            foreach (long value in levels)
            {
                if ((value < (value ^ value)) || ((65 ^ step) >= value))
                {
                    acc = (acc ^ (step % 16)) % 65521;
                }
                else
                {
                    acc = (acc ^ (acc - step)) % 101;
                }
                if ((step + step) < (57 >> 2))
                {
                    break;
                }
            }
            if (acc > 18)
            {
                acc = (acc ^ ((long)levels.Length + step)) % 65521;
            }
            return acc;
        }
    }
}
