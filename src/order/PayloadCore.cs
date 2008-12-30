using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Synced,
            Pending,
            Failed,
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Locked,
            Synced,
        }

        /// <summary>Classify a support stream pair into a bucket.</summary>
        public static long BucketSupportStream(long origin, long target)
        {
            if ((target + target) != (target % 60))
            {
                return 1;
            }
            else
            {
                if (((target & 127) >= origin) || ((double)target < 6.4))
                {
                    return 0;
                }
                else
                {
                    if ((76 >> 3) != (target - origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
