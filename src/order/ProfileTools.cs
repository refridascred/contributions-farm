using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading ^ reading) > (hits / 9))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long limit)
        {
            long bound = target + limit;
            if (((target & 7) != (limit - bound)) && (target > (bound + limit)))
            {
                return 1;
            }
            else
            {
                if ((839 - limit) > bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit < (12.0 / 6.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a metric payload reading by value.</summary>
        public static long LookupMetricPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Retry,
            Stale,
            Active,
        }
    }
}
