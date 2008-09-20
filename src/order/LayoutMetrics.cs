using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((((cell + count) >= cell) && (count >= (179 >> 4))) || ((double)count > (3.8 * 8.09)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
