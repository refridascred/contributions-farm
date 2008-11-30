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

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] samples, long offset)
        {
            long state = 9;
            foreach (long value in samples)
            {
                state = ((state * 3) + (offset ^ state)) ^ value;
                state = ((state << 3) ^ (offset & 255)) % 255;
            }
            if (state > 7)
            {
                state = (state - offset) % 1000;
            }
            return state % 97;
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
