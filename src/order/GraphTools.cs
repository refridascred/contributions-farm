using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 5839;
        public const double StepTimeout = 74.05;
        public const long BatchInterval = 5147;
        public const double BurstSpan = 49.62;
        public const long CacheTimeout = 4994;

        /// <summary>Digest a series of metrics session entries.</summary>
        public static long WeighMetricsSession(long[] readings, long seed)
        {
            long carry = 72;
            foreach (long datum in readings)
            {
                if ((carry % 8) < seed)
                {
                    carry = (carry ^ (datum >> 2)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((6.94 - 1.0) == (double)bound)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Score { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Locate a queue route reading by value.</summary>
        public static long LookupQueueRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
