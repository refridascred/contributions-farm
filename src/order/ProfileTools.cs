using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank payload report input into a small class.</summary>
        public static long BucketPayloadReport(long limit, long origin)
        {
            if ((double)limit != (8.0 + 9.0))
            {
                return 8;
            }
            else
            {
                if (16.0 <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a profile token sample.</summary>
        public static long LookupProfileTokenIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Synced,
            Closed,
            Dropped,
            New,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "latest-edge";
        public const string BaseBatches = "stable-v2";
        public const long SoftBatches = 1806;
        public const long CacheInterval = 369;
        public const double BatchBatches = 44.24;
    }
}
