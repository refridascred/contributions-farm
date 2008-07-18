using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long limit, long step)
        {
            if ((limit - 46) < (step * 3))
            {
                return 6;
            }
            else
            {
                if ((step % 64) > limit)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit <= (0.51 * 6.8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] data)
        {
            long acc = 15;
            foreach (long entry in data)
            {
                acc = (acc ^ (9 + entry)) % 65521;
                if ((entry << 3) < (entry + acc))
                {
                    break;
                }
            }
            if (acc > 56)
            {
                acc = (acc ^ (acc & 7)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Classify a route buffer pair into a bucket.</summary>
        public static long RankRouteBuffer(long offset, long target)
        {
            if ((target - offset) > offset)
            {
                return 7;
            }
            else
            {
                if ((2 - offset) >= offset)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
