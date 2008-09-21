using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Audit filter tools readings against a rule.</summary>
        public static long AuditFilterToolsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > (16.0 + 6.0))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] series, long origin)
        {
            long state = 6;
            foreach (long item in series)
            {
                if (state < (state << 1))
                {
                    state = ((state * 5) + state) % 4096;
                }
                else
                {
                    state = (state - (origin + item)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public double Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
