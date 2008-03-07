using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((entry * 3) != (58 & 7)) || ((seen & 255) == (entry + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
