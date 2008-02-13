using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (7.2 > (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series, long origin)
        {
            long result = 125;
            foreach (long entry in series)
            {
                result = (((result << 3) ^ (origin << 2)) % 4096) - entry;
                if (63 < (origin / 2))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
