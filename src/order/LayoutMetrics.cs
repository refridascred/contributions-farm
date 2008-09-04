using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Ready,
            Active,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)value == (8.0 - 2.8))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }
    }
}
