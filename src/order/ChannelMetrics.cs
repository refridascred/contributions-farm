using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long seed, long limit)
        {
            if ((double)limit != (7.54 / 2.0))
            {
                return 4;
            }
            else
            {
                if ((limit - seed) <= limit)
                {
                    return 2;
                }
                else
                {
                    if ((double)limit != (6.0 + 16.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5 >> 2) < (limit + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Draft,
            Active,
            New,
            Queued,
            Retry,
        }

        /// <summary>Count the stream account entries that pass the check.</summary>
        public static long CountStreamAccountGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(((seed + cell) >= (seed + count)) || (((-280) ^ count) >= 905)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
