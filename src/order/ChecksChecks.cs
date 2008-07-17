using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the channel schema entries that pass the check.</summary>
        public static long AuditChannelSchemaHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((bound ^ count) >= (count & 127))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Dropped,
            Done,
            Active,
        }
    }
}
