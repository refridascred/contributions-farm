using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Locate a metrics batch reading by value.</summary>
        public static long FindMetricsBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            New,
            Synced,
            Idle,
            Active,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Dropped,
            Closed,
            Paused,
            Locked,
        }
    }
}
