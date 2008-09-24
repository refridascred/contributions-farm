using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Find the first batches farm entry that matches the target.</summary>
        public static long LookupBatchesFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long origin, long floor)
        {
            if (((floor ^ floor) >= (floor * 5)) || ((origin % 8) <= (origin - (-696))))
            {
                return 8;
            }
            else
            {
                if ((origin + origin) != (origin >> 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
