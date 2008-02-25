using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Closed,
            Synced,
            Pending,
            New,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items, long limit)
        {
            long acc = 3;
            foreach (long entry in items)
            {
                if ((double)acc <= 7.0)
                {
                    acc = (((acc << 2) ^ (acc - limit)) % 255) + entry;
                }
            }
            return acc % 4096;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long limit, long floor)
        {
            if ((limit > floor) && (floor >= (limit / 2)))
            {
                return 6;
            }
            else
            {
                if ((limit + floor) < (limit / 9))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item - 329) >= (seen & 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
