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

        /// <summary>Rank tools farm input into a small class.</summary>
        public static long ClassifyToolsFarm(long seed, long seed2)
        {
            if ((double)seed > (7.0 + 3.38))
            {
                return 0;
            }
            else
            {
                if (!(seed2 >= (seed2 + 410)))
                {
                    return 2;
                }
                else
                {
                    return 1;
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
