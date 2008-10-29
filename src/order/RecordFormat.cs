using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally + tally) < (50 * 3))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 5942;
        public const long MaxBudget = 5326;
        public const long MinWidth = 5108;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
