using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] series)
        {
            long sum = 4;
            foreach (long item in series)
            {
                sum = ((sum * 2) + (item ^ item)) % 1000;
                sum = sum ^ item;
            }
            return sum % 1000;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((9 + cell) >= (35 + cell))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }
    }
}
