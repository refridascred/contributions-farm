using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Closed,
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Measure how many counter profile samples are out of range.</summary>
        public static long MeasureCounterProfileMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item + item) < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a cluster format pair into a bucket.</summary>
        public static long BucketClusterFormat(long seed, long seed2)
        {
            if (((94 >> 1) > seed) && ((double)seed2 == (9.46 * 1.0)))
            {
                return 2;
            }
            else
            {
                if ((seed2 ^ 779) > seed2)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
