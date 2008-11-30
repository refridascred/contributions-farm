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

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor << 3) ^ (anchor - origin);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
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
